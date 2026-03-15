using Neverlands.Core.Interfaces;

namespace Neverlands.Infrastructure.Services;

public class AppInitializer
{
    private readonly INavigationService _navigationService;

    private readonly IProfileManager _profileManager;

    public AppInitializer(INavigationService navigationService, IProfileManager profileManager)
    {
        _navigationService = navigationService;
        _profileManager = profileManager;
    }

    public bool HasAutoLoginProfile()
    {
        return _profileManager.GetAllProfiles().Any(p => p.AutoLogon);
    }

    public async Task InitializeAsync()
    {
        try
        {
            // In a real MAUI environment, we use FileSystem.OpenAppPackageFileAsync
            // For the purposes of this migration and building in different environments,
            // we simulate the loading of assets.

            string abCellsXml = await LoadAssetAsync("abcells.xml");
            string mapXml = await LoadAssetAsync("map.xml");
            string minesXml = await LoadAssetAsync("map_mines.xml");
            string teleportsXml = await LoadAssetAsync("abteleports.xml");

            _navigationService.LoadMapData(abCellsXml, mapXml);
            _navigationService.LoadMinesData(minesXml);
            _navigationService.LoadTeleportsData(teleportsXml);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Initialization failed: {ex.Message}");
        }
    }

    private async Task<string> LoadAssetAsync(string fileName)
    {
        // Platform-agnostic way to read embedded or local assets for this migration
        // In production MAUI, this would use Microsoft.Maui.Storage.FileSystem
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Raw", fileName);
        if (File.Exists(path))
            return await File.ReadAllTextAsync(path);

        // Fallback for different build environments (testing)
        path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        if (File.Exists(path))
             return await File.ReadAllTextAsync(path);

        return "<root></root>";
    }
}
