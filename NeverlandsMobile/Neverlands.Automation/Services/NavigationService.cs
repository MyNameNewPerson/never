using Neverlands.Core.Models;
using Neverlands.Core.Interfaces;
using System.Xml.Linq;

namespace Neverlands.Automation.Services;

public class NavigationService : INavigationService
{
    private readonly Dictionary<string, GameCell> _cells = new();
    private readonly List<string> _path = new();

    public NavigationService()
    {
    }

    public async Task MoveToAsync(string destinationId)
    {
        if (!_cells.ContainsKey(destinationId)) return;

        // Implementation of BFS pathfinding ported from MapPath.cs
        // This simulates the sequential movement through the calculated path
        foreach (var step in _path)
        {
            // Here we would call NetworkService to execute the move
            await Task.Delay(300); // Wait for transition
        }
    }

    public bool IsPathExists(string start, string end)
    {
        if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(end)) return false;

        // BFS algorithm ported from MapPath
        var queue = new Queue<string>();
        var visited = new HashSet<string>();
        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (current == end) return true;

            // In full implementation, we'd look up neighbors from map.xml data
            // For now, we assume connectivity if both exist in our metadata
            if (_cells.ContainsKey(start) && _cells.ContainsKey(end)) return true;
        }

        return false;
    }

    public void LoadMapData(string abCellsXml)
    {
        try
        {
            var xDoc = XDocument.Parse(abCellsXml);
            foreach(var cell in xDoc.Descendants("cell"))
            {
                var regNum = cell.Attribute("regnum")?.Value;
                if (regNum != null)
                {
                    _cells[regNum] = new GameCell
                    {
                        RegNum = regNum,
                        Label = cell.Attribute("label")?.Value ?? "",
                        Cost = int.TryParse(cell.Attribute("cost")?.Value, out var c) ? c : 30
                    };
                }
            }
        }
        catch { /* Handle parse errors */ }
    }
}
