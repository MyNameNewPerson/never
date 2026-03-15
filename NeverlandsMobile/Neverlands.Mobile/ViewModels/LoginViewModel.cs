using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;

namespace Neverlands.Mobile.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    private readonly IProfileManager _profileManager;

    [ObservableProperty] private string _login = string.Empty;
    [ObservableProperty] private string _password = string.Empty;
    [ObservableProperty] private bool _rememberPassword;
    [ObservableProperty] private bool _autoLogin;
    [ObservableProperty] private bool _isLoading;
    [ObservableProperty] private string _errorMessage = string.Empty;
    [ObservableProperty] private UserProfile? _selectedProfile;

    public ObservableCollection<UserProfile> Profiles { get; } = new();

    public LoginViewModel(IProfileManager profileManager)
    {
        _profileManager = profileManager;
        LoadProfiles();
    }

    private void LoadProfiles()
    {
        Profiles.Clear();
        foreach (var profile in _profileManager.GetAllProfiles())
        {
            Profiles.Add(profile);
        }
    }

    partial void OnSelectedProfileChanged(UserProfile? value)
    {
        if (value != null)
        {
            Login = value.Nickname;
            Password = value.Password;
            AutoLogin = value.AutoLogon;
            RememberPassword = !string.IsNullOrEmpty(value.Password);
        }
    }

    [RelayCommand]
    private async Task LoginAsync()
    {
        if (string.IsNullOrWhiteSpace(Login))
        {
            ErrorMessage = "Введите логин";
            return;
        }

        IsLoading = true;
        ErrorMessage = string.Empty;

        try
        {
            await Task.Delay(500); // Simulate network check

            var profile = _profileManager.GetAllProfiles().FirstOrDefault(p => p.Nickname == Login)
                          ?? new UserProfile { Nickname = Login };

            profile.Password = RememberPassword ? Password : string.Empty;
            profile.AutoLogon = AutoLogin;

            _profileManager.AddProfile(profile);
            _profileManager.SwitchProfile(profile.Nickname);
            await _profileManager.SaveProfilesAsync();

            await Shell.Current.GoToAsync("///MainPage");
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Ошибка входа: {ex.Message}";
        }
        finally
        {
            IsLoading = false;
        }
    }
}
