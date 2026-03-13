using CommunityToolkit.Mvvm.ComponentModel;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using System.Text.Json;

namespace Neverlands.Mobile.ViewModels;

public partial class ProfilesViewModel : ObservableObject
{
    private readonly ISecureStorageService _secureStorage;
    private const string ProfilesKey = "user_profiles";

    public ObservableCollection<UserProfile> Profiles { get; } = new();

    [ObservableProperty]
    private string _newNickname = "";

    [ObservableProperty]
    private string _newPassword = "";

    public ProfilesViewModel(ISecureStorageService secureStorage)
    {
        _secureStorage = secureStorage;
        _ = LoadProfilesAsync();
    }

    private async Task LoadProfilesAsync()
    {
        var json = await _secureStorage.GetAsync(ProfilesKey);
        if (!string.IsNullOrEmpty(json))
        {
            var list = JsonSerializer.Deserialize<List<UserProfile>>(json);
            if (list != null)
            {
                Profiles.Clear();
                foreach (var p in list) Profiles.Add(p);
            }
        }
    }

    [RelayCommand]
    private async Task AddProfileAsync()
    {
        if (string.IsNullOrWhiteSpace(NewNickname)) return;

        var profile = new UserProfile
        {
            Nickname = NewNickname,
            CharacterName = NewNickname,
            Level = 1
        };

        Profiles.Add(profile);

        // Save password securely (simplified for multiple profiles)
        await _secureStorage.SaveAsync($"pwd_{NewNickname}", NewPassword);

        var json = JsonSerializer.Serialize(Profiles.ToList());
        await _secureStorage.SaveAsync(ProfilesKey, json);

        NewNickname = "";
        NewPassword = "";
    }

    [RelayCommand]
    private async Task DeleteProfileAsync(UserProfile profile)
    {
        if (profile == null) return;
        Profiles.Remove(profile);

        var json = JsonSerializer.Serialize(Profiles.ToList());
        await _secureStorage.SaveAsync(ProfilesKey, json);
        await _secureStorage.RemoveAsync($"pwd_{profile.Nickname}");
    }
}
