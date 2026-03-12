using Neverlands.Core.Models;
using Neverlands.Core.Interfaces;
using Neverlands.Infrastructure.Services;
using System.Xml.Linq;
using System.Globalization;

namespace Neverlands.Automation.Services;

public class NavigationService : INavigationService
{
    private readonly INetworkService _networkService;
    private readonly Dictionary<string, GameCell> _cells = new();
    private readonly Dictionary<string, string> _coordToCell = new(); // "X/Y_X" -> "regnum"

    public NavigationService(INetworkService networkService)
    {
        _networkService = networkService;
        InitializeCoordMapping();
    }

    private void InitializeCoordMapping()
    {
        InitializeRegion("1", 952, 954);
        InitializeRegion("2", 982, 954);
        InitializeRegion("3", 1012, 954);
        InitializeRegion("13", 1042, 954);
        InitializeRegion("4", 952, 973);
        InitializeRegion("5", 982, 973);
        InitializeRegion("6", 1012, 973);
        InitializeRegion("14", 1042, 973);
        InitializeRegion("7", 952, 992);
        InitializeRegion("8", 982, 992);
        InitializeRegion("9", 1012, 992);
        InitializeRegion("15", 1042, 992);
        InitializeRegion("10", 952, 1011);
        InitializeRegion("11", 982, 1011);
        InitializeRegion("12", 1012, 1011);
        InitializeRegion("16", 1042, 1011);
        InitializeRegion("17", 922, 954);
        InitializeRegion("18", 922, 973);
        InitializeRegion("19", 922, 992);
        InitializeRegion("20", 922, 1011);
        InitializeRegion("21", 922, 1030);
        InitializeRegion("22", 922, 1049);
        InitializeRegion("23", 952, 1030);
        InitializeRegion("24", 952, 1049);
        InitializeRegion("25", 982, 1030);
        InitializeRegion("26", 982, 1049);
        InitializeRegion("27", 1012, 1030);
        InitializeRegion("28", 1012, 1049);
        InitializeRegion("29", 1042, 1030);
        InitializeRegion("30", 1042, 1049);
        InitializeRegion("31", 1072, 954);
        InitializeRegion("32", 1072, 973);
        InitializeRegion("33", 1072, 992);
        InitializeRegion("34", 1072, 1011);
        InitializeRegion("35", 1072, 1030);
        InitializeRegion("36", 1072, 1049);
    }

    private void InitializeRegion(string regionPrefix, int startX, int startY)
    {
        int num = 1;
        int endX = startX + 29;
        int endY = startY + 18;
        for (int y = startY; y <= endY; y++)
        {
            for (int x = startX; x <= endX; x++)
            {
                string coordKey = $"{y}/{x}_{y}";
                string regNum = $"{regionPrefix}-{num:D3}";
                _coordToCell[coordKey] = regNum;
                num++;
            }
        }
    }

    public void LoadMapData(string abCellsXml, string mapXml)
    {
        try
        {
            // First load map.xml for base details and bots
            var mapDoc = XDocument.Parse(mapXml);
            foreach (var cellNode in mapDoc.Descendants("cell"))
            {
                var cellId = cellNode.Attribute("cellNumber")?.Value;
                if (cellId != null)
                {
                    var cell = new GameCell
                    {
                        RegNum = cellId,
                        Cost = int.TryParse(cellNode.Attribute("cost")?.Value, out var c) ? c : 30,
                        HasFish = bool.TryParse(cellNode.Attribute("hasFish")?.Value, out var f) && f,
                        HasWater = bool.TryParse(cellNode.Attribute("hasWater")?.Value, out var w) && w,
                        HerbGroup = cellNode.Attribute("herbGroup")?.Value ?? "0",
                        Label = cellNode.Attribute("name")?.Value ?? "",
                        Tooltip = cellNode.Attribute("tooltip")?.Value ?? ""
                    };

                    foreach (var botNode in cellNode.Elements("bots"))
                    {
                        cell.Bots.Add(new MapBot
                        {
                            Name = botNode.Attribute("name")?.Value ?? "",
                            MinLevel = int.TryParse(botNode.Attribute("minLevel")?.Value, out var min) ? min : 0,
                            MaxLevel = int.TryParse(botNode.Attribute("maxLevel")?.Value, out var max) ? max : 0,
                            C = botNode.Attribute("c")?.Value ?? "",
                            D = botNode.Attribute("d")?.Value ?? ""
                        });
                    }
                    _cells[cellId] = cell;
                }
            }

            // Then merge with abcells.xml for visited/verified status and extra labels
            var abDoc = XDocument.Parse(abCellsXml);
            foreach (var cellNode in abDoc.Descendants("cell"))
            {
                var regNum = cellNode.Attribute("regnum")?.Value;
                if (regNum != null)
                {
                    if (!_cells.TryGetValue(regNum, out var cell))
                    {
                        cell = new GameCell { RegNum = regNum };
                        _cells[regNum] = cell;
                    }

                    if (string.IsNullOrEmpty(cell.Label))
                        cell.Label = cellNode.Attribute("label")?.Value ?? "";

                    if (cellNode.Attribute("cost") != null && int.TryParse(cellNode.Attribute("cost")?.Value, out var cost))
                        cell.Cost = cost;

                    if (DateTime.TryParse(cellNode.Attribute("visited")?.Value, out var v))
                        cell.Visited = v;
                }
            }

            // Populate coordinates
            foreach (var entry in _coordToCell)
            {
                if (_cells.TryGetValue(entry.Value, out var cell))
                {
                    var parts = entry.Key.Split('/', '_');
                    if (parts.Length >= 2)
                    {
                        cell.Y = int.Parse(parts[0]);
                        cell.X = int.Parse(parts[1]);
                    }
                }
            }
        }
        catch { /* Handle parse errors */ }
    }

    public async Task MoveToAsync(string destinationId)
    {
        // Simple mock pathfinding for now, actual implementation would use BFS
        var currentId = "18-226"; // Mock current location
        var path = CalculatePath(currentId, destinationId);

        foreach (var step in path)
        {
            // Execute move via network service
            // The actual Neverlands URL for movement would be something like:
            // "game.php?v=move&dir=..." or similar legacy pattern
            // For now, we simulate.
            await _networkService.GetAsync($"https://neverlands.ru/move.php?target={step}");
            await Task.Delay(300);
        }
    }

    public bool IsPathExists(string start, string end)
    {
        if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(end)) return false;
        return CalculatePath(start, end).Count > 0;
    }

    private List<string> CalculatePath(string start, string end)
    {
        // Real BFS implementation
        if (!_cells.ContainsKey(start) || !_cells.ContainsKey(end)) return new List<string>();

        var queue = new Queue<string>();
        var parentMap = new Dictionary<string, string?>();
        queue.Enqueue(start);
        parentMap[start] = null;

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (current == end)
            {
                return ReconstructPath(parentMap, end);
            }

            foreach (var neighbor in GetNeighbors(current))
            {
                if (!parentMap.ContainsKey(neighbor))
                {
                    parentMap[neighbor] = current;
                    queue.Enqueue(neighbor);
                }
            }
        }

        return new List<string>();
    }

    private List<string> GetNeighbors(string cellId)
    {
        var neighbors = new List<string>();
        if (!_cells.TryGetValue(cellId, out var cell)) return neighbors;

        // In Neverlands, you can move to adjacent cells (Up, Down, Left, Right, Diagonals)
        for (int dy = -1; dy <= 1; dy++)
        {
            for (int dx = -1; dx <= 1; dx++)
            {
                if (dx == 0 && dy == 0) continue;

                string neighborCoord = $"{cell.Y + dy}/{cell.X + dx}_{cell.Y + dy}";
                if (_coordToCell.TryGetValue(neighborCoord, out var neighborRegNum))
                {
                    if (_cells.ContainsKey(neighborRegNum))
                        neighbors.Add(neighborRegNum);
                }
            }
        }
        return neighbors;
    }

    private List<string> ReconstructPath(Dictionary<string, string?> parentMap, string end)
    {
        var path = new List<string>();
        string? current = end;
        while (current != null)
        {
            path.Add(current);
            current = parentMap[current];
        }
        path.Reverse();
        path.RemoveAt(0); // Remove start node
        return path;
    }
}
