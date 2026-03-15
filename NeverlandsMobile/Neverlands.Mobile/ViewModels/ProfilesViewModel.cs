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
        Profiles.Clear();
        foreach (var profile in _profileManager.GetAllProfiles())
        {
            Profiles.Add(profile);
        }
    }

    [RelayCommand]
    private async Task AddProfileAsync()
    {
        var newProfile = new UserProfile { Nickname = "New Profile" };
        _profileManager.AddProfile(newProfile);
        await _profileManager.SaveProfilesAsync();
        Profiles.Add(newProfile);
    }
}
