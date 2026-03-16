using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;

namespace Neverlands.Mobile.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    private readonly IProfileManager _profileManager;
    private readonly ISecureStorageService _secureStorage;

    [ObservableProperty] private ObservableCollection<UserProfile> _profiles = new();
    [ObservableProperty] private UserProfile? _selectedProfile;
    [ObservableProperty] private string _login = string.Empty;
    [ObservableProperty] private string _password = string.Empty;
    [ObservableProperty] private bool _rememberPassword = true;
    [ObservableProperty] private bool _autoLogin;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotLoading))]
    private bool _isLoading;
    [ObservableProperty] private string _errorMessage = string.Empty;

    public bool IsNotLoading => !IsLoading;

    public LoginViewModel(IProfileManager profileManager, ISecureStorageService secureStorage)
    {
        _profileManager = profileManager;
        _secureStorage = secureStorage;
        LoadProfiles();
    }

    private void LoadProfiles()
    {
        Profiles = new ObservableCollection<UserProfile>(_profileManager.GetAllProfiles());
    }

    partial void OnSelectedProfileChanged(UserProfile? value)
    {
        if (value == null) return;
        Login = value.Nickname;
        Password = value.Password;
        AutoLogin = value.AutoLogon;
        RememberPassword = value.RememberPassword;
    }

    [RelayCommand]
    private async Task LoginAsync()
    {
        if (string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Password))
        {
            ErrorMessage = "Введите логин и пароль";
            return;
        }

        IsLoading = true;
        ErrorMessage = string.Empty;
        try
        {
            // ЭТАП 1: сначала просто сохранить и перейти (заглушка сети)
            var profile = _profileManager.GetAllProfiles().FirstOrDefault(p => p.Nickname == Login) ?? new UserProfile { Nickname = Login };
            profile.AutoLogon = AutoLogin;
            profile.RememberPassword = RememberPassword;
            profile.Password = RememberPassword ? Password : string.Empty;
            profile.LastLogin = DateTime.Now;

            _profileManager.AddProfile(profile);
            _profileManager.SwitchProfile(profile.Nickname);
            await _profileManager.SaveProfilesAsync();

            await Shell.Current.GoToAsync("///main");
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message;
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    private void AddProfile()
    {
        SelectedProfile = null;
        Login = string.Empty;
        Password = string.Empty;
        AutoLogin = false;
        RememberPassword = true;
        ErrorMessage = string.Empty;
    }

    [RelayCommand]
    private async Task DeleteProfileAsync()
    {
        if (SelectedProfile == null) return;

        bool confirm = await Shell.Current.DisplayAlert("Удаление", $"Удалить профиль {SelectedProfile.Nickname}?", "Да", "Нет");
        if (confirm)
        {
            _profileManager.DeleteProfile(SelectedProfile.Nickname);
            await _profileManager.SaveProfilesAsync();
            LoadProfiles();
            AddProfile();
        }
    }
}
