using CommunityToolkit.Mvvm.ComponentModel;

namespace Neverlands.Mobile.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    private readonly ISecureStorageService _secureStorage;

    public SettingsViewModel(ISecureStorageService secureStorage)
    {
        _secureStorage = secureStorage;
        LoadSettings();
    }

    [ObservableProperty] private bool _autoWoodcutting;
    [ObservableProperty] private bool _autoCombat;

    private async void LoadSettings()
    {
        AutoWoodcutting = (await _secureStorage.GetCredentialAsync("AutoWoodcutting")) == "true";
        AutoCombat = (await _secureStorage.GetCredentialAsync("AutoCombat")) == "true";
    }

    partial void OnAutoWoodcuttingChanged(bool value)
    {
        _secureStorage.SaveCredentialAsync("AutoWoodcutting", value.ToString().ToLower());
    }

    partial void OnAutoCombatChanged(bool value)
    {
        _secureStorage.SaveCredentialAsync("AutoCombat", value.ToString().ToLower());
    }
}
