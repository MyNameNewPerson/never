using CommunityToolkit.Mvvm.ComponentModel;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace Neverlands.Mobile.ViewModels;

public partial class ProfilesViewModel : ObservableObject
{
    private readonly ISecureStorageService _secureStorage;

    public ObservableCollection<UserProfile> Profiles { get; } = new();

    public ProfilesViewModel(ISecureStorageService secureStorage)
    {
        _secureStorage = secureStorage;
        LoadProfiles();
    }

    private void LoadProfiles()
    {
        // Simulated loading for now, but wired to secureStorage in a real scenario
        Profiles.Clear();
        Profiles.Add(new UserProfile { Nickname = "Hero", CharacterName = "DragonSlayer", Level = 15 });
    }

    [RelayCommand]
    private async Task AddProfile()
    {
        // Logic to add a profile and save credentials
        await Task.CompletedTask;
    }
}
