using Neverlands.Core.Models;

namespace Neverlands.Core.Interfaces;

public interface INavigationService
{
    Task MoveToAsync(string startId, string destinationId);
    bool IsPathExists(string start, string end);
    void LoadMapData(string abCellsXml, string mapXml);
    void LoadMinesData(string minesXml);
    void LoadTeleportsData(string teleportsXml);
    IEnumerable<GameCell> GetNearbyCells(string cellId);
}
