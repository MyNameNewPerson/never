using CommunityToolkit.Mvvm.ComponentModel;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;

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
        // For demonstration, we could load from local db or settings.
        // Assuming a single primary profile for now.
        Profiles.Add(new UserProfile { Nickname = "Main Character" });
    }

    [RelayCommand]
    private void AddProfile()
    {
        Profiles.Add(new UserProfile { Nickname = "New Profile" });
    }
}
