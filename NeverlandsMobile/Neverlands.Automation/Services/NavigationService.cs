using Neverlands.Core.Models;
using Neverlands.Core.Interfaces;
using System.Xml.Linq;
using System.Globalization;

#if !DEBUG || ANDROID || IOS || WINDOWS
using Microsoft.Maui.Storage;
#endif

namespace Neverlands.Automation.Services;

public class NavigationService : INavigationService
{
    private readonly INetworkService _networkService;
    private readonly Dictionary<string, GameCell> _cells = new();
    private readonly Dictionary<string, (int X, int Y)> _cellToCoords = new();
    private readonly Dictionary<string, string> _coordsToCell = new();
    private readonly HashSet<string> _teleports = new();
    private bool _isLoaded = false;
    private List<string> _currentPath = new();

    public NavigationService(INetworkService networkService)
    {
        _networkService = networkService;
    }

    public async Task InitializeAsync()
    {
        if (_isLoaded) return;
        await LoadAllDataAsync();
    }

    private async Task LoadAllDataAsync()
    {
        InitializeCoordinateMapping();

        try
        {
            await LoadXmlFileAsync("map.xml", doc =>
            {
                foreach (var cellNode in doc.Descendants("cell"))
                {
                    var regNum = cellNode.Attribute("cellNumber")?.Value?.Trim();
                    if (string.IsNullOrEmpty(regNum)) continue;

                    if (!_cells.TryGetValue(regNum, out var cell))
                    {
                        cell = new GameCell { RegNum = regNum };
                        _cells[regNum] = cell;
                    }

                    cell.Cost = int.TryParse(cellNode.Attribute("cost")?.Value, out var c) ? c : 30;
                    cell.HasFish = bool.TryParse(cellNode.Attribute("hasFish")?.Value, out var f) && f;
                    cell.HasWater = bool.TryParse(cellNode.Attribute("hasWater")?.Value, out var w) && w;
                    cell.HerbGroup = cellNode.Attribute("herbGroup")?.Value?.Trim() ?? "0";
                    cell.Label = cellNode.Attribute("name")?.Value?.Trim() ?? "";
                    cell.Tooltip = cellNode.Attribute("tooltip")?.Value?.Trim() ?? "";

                    foreach (var botNode in cellNode.Descendants("bots"))
                    {
                        cell.Bots.Add(new MapBot
                        {
                            Name = botNode.Attribute("name")?.Value ?? "",
                            MinLevel = int.TryParse(botNode.Attribute("minLevel")?.Value, out var min) ? min : 0,
                            MaxLevel = int.TryParse(botNode.Attribute("maxLevel")?.Value, out var max) ? max : 0
                        });
                    }
                }
            });

            await LoadXmlFileAsync("abcells.xml", doc =>
            {
                foreach (var cellNode in doc.Descendants("cell"))
                {
                    var regNum = cellNode.Attribute("regnum")?.Value?.Trim();
                    if (string.IsNullOrEmpty(regNum)) continue;

                    if (!_cells.TryGetValue(regNum, out var cell))
                    {
                        cell = new GameCell { RegNum = regNum };
                        _cells[regNum] = cell;
                    }

                    var labelAttr = cellNode.Attribute("label");
                    if (labelAttr != null)
                        cell.Label = labelAttr.Value;

                    var costAttr = cellNode.Attribute("cost");
                    if (costAttr != null && int.TryParse(costAttr.Value, out var cost))
                        cell.Cost = cost;

                    var visitedAttr = cellNode.Attribute("visited");
                    if (visitedAttr != null && DateTime.TryParse(visitedAttr.Value, out var visited))
                        cell.Visited = visited;
                }
            });

            await LoadXmlFileAsync("abteleports.xml", doc =>
            {
                foreach (var teleNode in doc.Descendants("teleport"))
                {
                    var regNum = teleNode.Attribute("regnum")?.Value?.Trim();
                    if (!string.IsNullOrEmpty(regNum))
                    {
                        _teleports.Add(regNum);
                        if (_cells.TryGetValue(regNum, out var cell))
                        {
                            cell.IsTeleport = true;
                        }
                    }
                }
            });

            _isLoaded = true;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error loading map data: {ex.Message}");
        }
    }

    private async Task LoadXmlFileAsync(string fileName, Action<XDocument> processAction)
    {
        Stream? stream = null;
#if !DEBUG || ANDROID || IOS || WINDOWS
        try { stream = await FileSystem.OpenAppPackageFileAsync(fileName); } catch { }
#endif
        if (stream == null)
        {
            // Fallback for tests or local execution
            var paths = new[] { fileName, Path.Combine("Resources", "Raw", fileName), Path.Combine("..", "Neverlands.Mobile", "Resources", "Raw", fileName) };
            foreach (var path in paths)
            {
                if (File.Exists(path))
                {
                    stream = File.OpenRead(path);
                    break;
                }
            }
        }

        if (stream != null)
        {
            using (stream)
            {
                var doc = XDocument.Load(stream);
                processAction(doc);
            }
        }
    }

    private void InitializeCoordinateMapping()
    {
        string[] prefixes = { "1", "2", "3", "13", "4", "5", "6", "14", "7", "8", "9", "15", "10", "11", "12", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36" };
        int[] startXs = { 952, 982, 1012, 1042, 952, 982, 1012, 1042, 952, 982, 1012, 1042, 952, 982, 1012, 1042, 922, 922, 922, 922, 922, 922, 952, 952, 982, 982, 1012, 1012, 1042, 1042, 1072, 1072, 1072, 1072, 1072, 1072 };
        int[] startYs = { 954, 954, 954, 954, 973, 973, 973, 973, 992, 992, 992, 992, 1011, 1011, 1011, 1011, 954, 973, 992, 1011, 1030, 1049, 1030, 1049, 1030, 1049, 1030, 1049, 1030, 1049, 954, 973, 992, 1011, 1030, 1049 };

        for (int i = 0; i < prefixes.Length; i++)
        {
            AddRegion(prefixes[i], startXs[i], startYs[i]);
        }
    }

    private void AddRegion(string prefix, int startX, int startY)
    {
        int num = 1;
        int endX = startX + 29;
        int endY = startY + 18;
        for (int y = startY; y <= endY; y++)
        {
            for (int x = startX; x <= endX; x++)
            {
                string coordKey = $"{y}/{x}_{y}";
                string regNum = $"{prefix}-{num:D3}";
                _cellToCoords[regNum] = (x, y);
                _coordsToCell[coordKey] = regNum;
                num++;
            }
        }
    }

    public async Task MoveToAsync(string destinationId)
    {
        if (!_isLoaded) await InitializeAsync();
        if (string.IsNullOrEmpty(destinationId)) return;

        // In a real scenario, we calculate the path from current location
        // For now, use the cached path if it exists and ends at destinationId
        if (_currentPath.Count == 0 || _currentPath.Last() != destinationId)
        {
            // Fallback pathfinding from current location (not implemented here, assuming current path is set by IsPathExists)
            return;
        }

        foreach (var step in _currentPath)
        {
            if (!_cells.TryGetValue(step, out var cell)) continue;

            // Send movement request to server
            // Original format: main.php?get_id=2&go=PREFIX-NUM&vcode=VCODE
            // Mobile client should handle session/vcode internally in NetworkService or similar
            string moveUrl = $"http://www.neverlands.ru/main.php?get_id=2&go={step}";
            await _networkService.GetAsync(moveUrl);

            // Wait for movement cost
            await Task.Delay(cell.Cost * 1000);
        }
    }

    public bool IsPathExists(string start, string end)
    {
        var path = FindPath(start, end);
        _currentPath = path;
        return path.Count > 0;
    }

    public List<string> FindPath(string start, string end)
    {
        if (!_cells.ContainsKey(start) || !_cells.ContainsKey(end)) return new List<string>();
        if (start == end) return new List<string> { start };

        var pq = new PriorityQueue<PathNode, PathNode>();
        var minCosts = new Dictionary<(string CellId, bool HasTeleported), int>();

        var startNode = new PathNode(start, null, false, 0, 1);
        pq.Enqueue(startNode, startNode);
        minCosts[(start, false)] = 0;

        PathNode? targetNode = null;

        while (pq.Count > 0)
        {
            var current = pq.Dequeue();

            if (current.CellId == end)
            {
                if (targetNode == null || current.CompareTo(targetNode) < 0)
                {
                    targetNode = current;
                }
                break;
            }

            if (targetNode != null && current.CompareTo(targetNode) >= 0)
                continue;

            foreach (var (neighborId, isGate, isTeleport) in GetNeighbors(current.CellId, current.HasTeleported))
            {
                bool hasTeleported = current.HasTeleported || isTeleport;
                int stepCost = (isGate || isTeleport) ? 0 : (_cells.TryGetValue(current.CellId, out var c) ? c.Cost : 30);
                int newCost = current.TotalCost + stepCost;

                var state = (neighborId, hasTeleported);
                if (!minCosts.TryGetValue(state, out int bestCost) || newCost < bestCost)
                {
                    minCosts[state] = newCost;
                    var newNode = new PathNode(neighborId, current, hasTeleported, newCost, current.Length + 1);
                    pq.Enqueue(newNode, newNode);
                }
            }
        }

        if (targetNode == null) return new List<string>();

        var path = new List<string>();
        var curr = targetNode;
        while (curr != null)
        {
            path.Add(curr.CellId);
            curr = curr.Parent;
        }
        path.Reverse();
        return path;
    }

    private IEnumerable<(string neighborId, bool isGate, bool isTeleport)> GetNeighbors(string cellId, bool alreadyTeleported)
    {
        if (!_cellToCoords.TryGetValue(cellId, out var coords)) yield break;

        // 8 directions
        int[] dx = { 0, 0, -1, 1, -1, 1, -1, 1 };
        int[] dy = { -1, 1, 0, 0, -1, -1, 1, 1 };

        for (int i = 0; i < 8; i++)
        {
            int nx = coords.X + dx[i];
            int ny = coords.Y + dy[i];
            string coordKey = $"{ny}/{nx}_{ny}";
            if (_coordsToCell.TryGetValue(coordKey, out var neighborId))
            {
                if (_cells.ContainsKey(neighborId))
                    yield return (neighborId, false, false);
            }
        }

        // Gates
        string[] gates = cellId switch
        {
            "12-521" => new[] { "12-428", "12-494" },
            "12-494" => new[] { "12-428", "12-521" },
            "12-428" => new[] { "12-494", "12-521" },
            "8-294" => new[] { "8-259" },
            "8-259" => new[] { "8-294" },
            _ => Array.Empty<string>()
        };
        foreach (var gateId in gates)
        {
            if (_cells.ContainsKey(gateId))
                yield return (gateId, true, false);
        }

        // Teleports
        if (!alreadyTeleported)
        {
            foreach (var teleId in _teleports)
            {
                if (teleId != cellId && _cells.ContainsKey(teleId))
                    yield return (teleId, false, true);
            }
        }
    }

    private class PathNode : IComparable<PathNode>
    {
        public string CellId { get; }
        public PathNode? Parent { get; }
        public bool HasTeleported { get; }
        public int TotalCost { get; }
        public int Length { get; }

        public PathNode(string cellId, PathNode? parent, bool hasTeleported, int totalCost, int length)
        {
            CellId = cellId;
            Parent = parent;
            HasTeleported = hasTeleported;
            TotalCost = totalCost;
            Length = length;
        }

        public int CompareTo(PathNode? other)
        {
            if (other == null) return -1;
            int c = TotalCost.CompareTo(other.TotalCost);
            if (c != 0) return c;
            c = Length.CompareTo(other.Length);
            if (c != 0) return c;
            return HasTeleported.CompareTo(other.HasTeleported);
        }
    }

    public void LoadMapData(string abCellsXml) { }
}
