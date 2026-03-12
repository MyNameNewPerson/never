using CommunityToolkit.Mvvm.ComponentModel;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;

namespace Neverlands.Mobile.ViewModels;

public partial class MapViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;
    [ObservableProperty] private string _currentLocation = "18-226";
    public ObservableCollection<GameCell> NearbyCells { get; } = new();

    public MapViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }
}
