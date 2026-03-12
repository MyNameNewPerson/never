using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;

namespace Neverlands.Mobile.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    private readonly ISecureStorageService _secureStorage;

    [ObservableProperty]
    private bool _isBackgroundAutomationEnabled;

    [ObservableProperty]
    private string _antiCaptchaKey = string.Empty;

    public SettingsViewModel(ISecureStorageService secureStorage)
    {
        _secureStorage = secureStorage;
        LoadSettings();
    }

    private async void LoadSettings()
    {
        AntiCaptchaKey = await _secureStorage.GetTokenAsync("anti_captcha_key") ?? string.Empty;
    }

    [RelayCommand]
    private async Task SaveSettings()
    {
        await _secureStorage.SaveTokenAsync("anti_captcha_key", AntiCaptchaKey);
        // Save other settings
    }
}
