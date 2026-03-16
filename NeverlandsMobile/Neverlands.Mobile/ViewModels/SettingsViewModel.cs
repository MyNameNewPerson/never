using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;

namespace Neverlands.Mobile.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    private readonly ISecureStorageService _secureStorage;
    private readonly IProfileManager _profileManager;

    [ObservableProperty] private string _antiCaptchaKey = string.Empty;
    [ObservableProperty] private int _actionDelay = 1000;
    [ObservableProperty] private bool _isLoggingEnabled = true;
    [ObservableProperty] private string _userAgent = "NeverlandsMobile/1.0";

    public SettingsViewModel(ISecureStorageService secureStorage, IProfileManager profileManager)
    {
        _secureStorage = secureStorage;
        _profileManager = profileManager;
        LoadSettings();
    }

    private async void LoadSettings()
    {
        AntiCaptchaKey = await _secureStorage.GetCredentialAsync("AntiCaptchaKey") ?? string.Empty;
        ActionDelay = Preferences.Default.Get("ActionDelay", 1000);
        IsLoggingEnabled = Preferences.Default.Get("IsLoggingEnabled", true);
        UserAgent = Preferences.Default.Get("UserAgent", "NeverlandsMobile/1.0");
    }

    [RelayCommand]
    private async Task Save()
    {
        await _secureStorage.SaveCredentialAsync("AntiCaptchaKey", AntiCaptchaKey);
        Preferences.Default.Set("ActionDelay", ActionDelay);
        Preferences.Default.Set("IsLoggingEnabled", IsLoggingEnabled);
        Preferences.Default.Set("UserAgent", UserAgent);

        var activeProfile = _profileManager.GetActiveProfile();
        if (activeProfile != null)
        {
            activeProfile.AntiCaptchaKey = AntiCaptchaKey;
            await _profileManager.SaveProfilesAsync();
        }

        await Shell.Current.DisplayAlert("Настройки", "Настройки сохранены", "OK");
    }

    [RelayCommand]
    private async Task Reset()
    {
        bool confirm = await Shell.Current.DisplayAlert("Сброс", "Сбросить все настройки к значениям по умолчанию?", "Да", "Нет");
        if (confirm)
        {
            AntiCaptchaKey = string.Empty;
            ActionDelay = 1000;
            IsLoggingEnabled = true;
            UserAgent = "NeverlandsMobile/1.0";
            await Save();
        }
    }
}
