using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace Neverlands.Mobile.ViewModels;

public partial class MapCellViewModel : ObservableObject
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int Row { get; set; }
    public int Column { get; set; }
    public string Type { get; set; } = string.Empty;
    public Color CellColor { get; set; } = Colors.Gray;
}

public partial class MapViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<MapCellViewModel> _cells = new();
    [ObservableProperty] private MapCellViewModel? _selectedCell;
    [ObservableProperty] private bool _hasSelectedCell;

    public string SelectedCellName => SelectedCell?.Name ?? string.Empty;

    public MapViewModel()
    {
        _ = LoadMapData();
    }

    private async Task LoadMapData()
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("map.xml");
            var doc = XDocument.Load(stream);
            var cellsList = new List<MapCellViewModel>();

            // Assuming map.xml structure: <map><cell id="..." name="..." x="..." y="..." type="..." /></map>
            foreach (var element in doc.Descendants("cell"))
            {
                var cell = new MapCellViewModel
                {
                    Id = element.Attribute("id")?.Value ?? string.Empty,
                    Name = element.Attribute("name")?.Value ?? string.Empty,
                    Column = int.TryParse(element.Attribute("x")?.Value, out int x) ? x : 0,
                    Row = int.TryParse(element.Attribute("y")?.Value, out int y) ? y : 0,
                    Type = element.Attribute("type")?.Value ?? string.Empty
                };

                cell.CellColor = cell.Type.ToLower() switch
                {
                    "city" => Colors.Gold,
                    "forest" => Colors.ForestGreen,
                    "mine" => Colors.Brown,
                    "teleport" => Colors.Purple,
                    "water" => Colors.Blue,
                    _ => Colors.Gray
                };

                cellsList.Add(cell);
            }

            Cells = new ObservableCollection<MapCellViewModel>(cellsList);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Failed to load map: {ex.Message}");
        }
    }

    [RelayCommand]
    private void SelectCell(MapCellViewModel cell)
    {
        SelectedCell = cell;
        HasSelectedCell = cell != null;
    }

    [RelayCommand]
    private async Task GoToCell()
    {
        if (SelectedCell == null) return;
        // Logic to send move command via NavigationService would go here
        await Shell.Current.DisplayAlert("Навигация", $"Вы идете в {SelectedCell.Name}", "OK");
        HasSelectedCell = false;
        SelectedCell = null;
    }
}
