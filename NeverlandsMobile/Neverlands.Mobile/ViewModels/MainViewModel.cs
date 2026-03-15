using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Models;
using Neverlands.Core.Interfaces;
using System.Collections.ObjectModel;
using System.Text;

namespace Neverlands.Mobile.ViewModels;

public partial class MainViewModel : ObservableObject {
    private readonly ICombatService _combatService;
    private readonly INavigationService _navigationService;
    private readonly IProfileManager _profileManager;

    [ObservableProperty] private GameState _state = new();
    [ObservableProperty] private string _statusMessage = "Ready";
    [ObservableProperty] private string _characterName = "Unknown";
    [ObservableProperty] private int _level = 0;
    [ObservableProperty] private int _currentHp = 100;
    [ObservableProperty] private int _maxHp = 100;
    [ObservableProperty] private int _currentMp = 50;
    [ObservableProperty] private int _maxMp = 50;
    [ObservableProperty] private string _currentLocation = "Загрузка...";
    [ObservableProperty] private bool _isAutomationRunning;
    [ObservableProperty] private string _eventLogText = string.Empty;

    public double HpPercent => MaxHp > 0 ? (double)CurrentHp / MaxHp : 0;
    public double MpPercent => MaxMp > 0 ? (double)CurrentMp / MaxMp : 0;
    public string HpStatus => $"{CurrentHp}/{MaxHp}";
    public string MpStatus => $"{CurrentMp}/{MaxMp}";

    private StringBuilder _eventLogBuilder = new StringBuilder();

    public MainViewModel(ICombatService combatService, INavigationService navigationService, IProfileManager profileManager) {
        _combatService = combatService;
        _navigationService = navigationService;
        _profileManager = profileManager;

        var profile = _profileManager.GetActiveProfile();
        if (profile != null) {
            CharacterName = profile.Nickname;
        }

        AddLogEvent("Приложение запущено");
    }

    private void AddLogEvent(string message) {
        _eventLogBuilder.AppendLine($"[{DateTime.Now:HH:mm:ss}] {message}");
        EventLogText = _eventLogBuilder.ToString();
    }

    [RelayCommand] private async Task MoveNorth() => await MoveAsync("North");
    [RelayCommand] private async Task MoveSouth() => await MoveAsync("South");
    [RelayCommand] private async Task MoveWest() => await MoveAsync("West");
    [RelayCommand] private async Task MoveEast() => await MoveAsync("East");

    private async Task MoveAsync(string direction) {
        AddLogEvent($"Движение на {direction}...");
        await Task.Delay(500);
        AddLogEvent($"Вы переместились на {direction}");
    }

    [RelayCommand] private void ToggleAutomation() {
        IsAutomationRunning = !IsAutomationRunning;
        StatusMessage = IsAutomationRunning ? "Automation Running..." : "Automation Stopped";
        AddLogEvent(StatusMessage);
    }

    [RelayCommand] private async Task OpenMap() => await Shell.Current.GoToAsync("///MapPage");
    [RelayCommand] private async Task OpenCharacter() => await Shell.Current.GoToAsync("CharacterPage");
}
