using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;

namespace Neverlands.Mobile.ViewModels;

public partial class GameCellViewModel : ObservableObject
{
    public GameCell Cell { get; }
    public bool IsCurrent { get; }
    public string RegNum => Cell.RegNum;
    public string Label => Cell.Label;
    public string BackgroundColor => Cell.IsMine ? "#704214" : (Cell.HasWater ? "#0077BE" : "#4CAF50");

    public GameCellViewModel(GameCell cell, bool isCurrent)
    {
        Cell = cell;
        IsCurrent = isCurrent;
    }
}

public partial class MapViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;
    [ObservableProperty] private string _currentLocation = "18-226";
    public ObservableCollection<GameCellViewModel> MapCells { get; } = new();

    public MapViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        LoadMap();
    }

    private void LoadMap()
    {
        // For simulation, we load nearby cells from navigation service
        // In a real implementation, this would dynamically build the grid based on character X/Y
        var cells = _navigationService.GetNearbyCells(CurrentLocation);
        MapCells.Clear();
        foreach (var cell in cells)
        {
            MapCells.Add(new GameCellViewModel(cell, cell.RegNum == CurrentLocation));
        }
    }

    [RelayCommand]
    private async Task CellSelected(GameCellViewModel cellVm)
    {
        bool answer = await Shell.Current.DisplayAlert("Перемещение", $"Перейти в локацию {cellVm.Label} ({cellVm.RegNum})?", "Да", "Нет");
        if (answer)
        {
            CurrentLocation = cellVm.RegNum;
            LoadMap();
        }
    }
}
