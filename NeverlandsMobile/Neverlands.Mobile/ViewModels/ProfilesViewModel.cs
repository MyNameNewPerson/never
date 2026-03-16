using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;

namespace Neverlands.Mobile.ViewModels;

public partial class ProfilesViewModel : ObservableObject
{
    private readonly IProfileManager _profileManager;
    [ObservableProperty] private ObservableCollection<UserProfile> _profiles = new();

    public ProfilesViewModel(IProfileManager profileManager)
    {
        _profileManager = profileManager;
    }

    // Use OnAppearing in view to call this if needed, or constructor
    public void LoadProfiles()
    {
        RefreshProfiles();
    }

    private void RefreshProfiles()
    {
        var activeProfile = _profileManager.GetActiveProfile();
        var allProfiles = _profileManager.GetAllProfiles().ToList();
        foreach (var p in allProfiles)
        {
            p.IsActive = (activeProfile != null && p.Nickname == activeProfile.Nickname);
        }
        Profiles = new ObservableCollection<UserProfile>(allProfiles);
    }

    [RelayCommand]
    private async Task Add()
    {
        await Shell.Current.GoToAsync("//login");
    }

    [RelayCommand]
    private async Task Login(UserProfile profile)
    {
        if (profile == null) return;
        profile.LastLogin = DateTime.Now;
        _profileManager.SwitchProfile(profile.Nickname);
        await _profileManager.SaveProfilesAsync();
        await Shell.Current.GoToAsync("///main");
    }

    [RelayCommand]
    private async Task Delete(UserProfile profile)
    {
        if (profile == null) return;
        bool answer = await Shell.Current.DisplayAlert("Удаление", $"Вы уверены, что хотите удалить профиль {profile.Nickname}?", "Да", "Нет");
        if (answer)
        {
            _profileManager.DeleteProfile(profile.Nickname);
            await _profileManager.SaveProfilesAsync();
            RefreshProfiles();
        }
    }
}
