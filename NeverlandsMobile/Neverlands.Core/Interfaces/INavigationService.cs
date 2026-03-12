namespace Neverlands.Core.Interfaces;
public interface INavigationService {
    Task MoveToAsync(string destinationId);
    bool IsPathExists(string start, string end);
    void LoadMapData(string abCellsXml, string mapXml);
}
