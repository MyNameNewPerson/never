using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;

namespace Neverlands.Mobile.ViewModels;

public partial class ProfilesViewModel : ObservableObject
{
    private readonly IProfileManager _profileManager;
    public ObservableCollection<UserProfile> Profiles { get; } = new();

    public ProfilesViewModel(IProfileManager profileManager)
    {
        _profileManager = profileManager;
        LoadProfiles();
    }

    private async void LoadProfiles()
    {
        await _profileManager.LoadProfilesAsync();
        RefreshProfiles();
    }

    private void RefreshProfiles()
    {
        Profiles.Clear();
        foreach (var profile in _profileManager.GetAllProfiles())
        {
            Profiles.Add(profile);
        }
    }

    [RelayCommand]
    private async Task AddProfileAsync()
    {
        await Shell.Current.GoToAsync("//LoginPage");
    }

    [RelayCommand]
    private async Task ActivateProfileAsync(UserProfile profile)
    {
        foreach (var p in _profileManager.GetAllProfiles())
        {
            p.AutoLogon = (p.Nickname == profile.Nickname);
        }
        await _profileManager.SaveProfilesAsync();
        RefreshProfiles();
    }

    [RelayCommand]
    private async Task LoginWithProfileAsync(UserProfile profile)
    {
        _profileManager.SwitchProfile(profile.Nickname);
        await Shell.Current.GoToAsync("///MainPage");
    }

    [RelayCommand]
    private async Task DeleteProfileAsync(UserProfile profile)
    {
        bool answer = await Shell.Current.DisplayAlert("Удаление", $"Вы уверены, что хотите удалить профиль {profile.Nickname}?", "Да", "Нет");
        if (answer)
        {
            _profileManager.DeleteProfile(profile.Nickname);
            await _profileManager.SaveProfilesAsync();
            RefreshProfiles();
        }
    }
}
