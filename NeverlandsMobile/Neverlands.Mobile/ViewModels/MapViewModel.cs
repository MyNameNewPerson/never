using CommunityToolkit.Mvvm.ComponentModel;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;

namespace Neverlands.Mobile.ViewModels;

public partial class MapViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;

    [ObservableProperty]
    private string _currentLocation = "Unknown";

    [ObservableProperty]
    private string _destinationId = string.Empty;

    public ObservableCollection<string> NearbyCells { get; } = new();

    public MapViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        InitializeAsync();
    }

    private async void InitializeAsync()
    {
        // Ensure map data is loaded
        if (_navigationService is NavigationService ns)
        {
            await ns.InitializeAsync();
        }
    }
}
