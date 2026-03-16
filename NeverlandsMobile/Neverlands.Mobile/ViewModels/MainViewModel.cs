using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using System.Collections.ObjectModel;
using System.Text;

namespace Neverlands.Mobile.ViewModels;

public partial class MainViewModel : ObservableObject {
    private readonly ICombatService _combatService;
    private readonly INavigationService _navigationService;
    private readonly IProfileManager _profileManager;

    [ObservableProperty] private string _characterName = "Unknown";
    [ObservableProperty] private int _level = 0;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HpPercent))]
    [NotifyPropertyChangedFor(nameof(HpStatus))]
    private int _currentHp = 100;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HpPercent))]
    [NotifyPropertyChangedFor(nameof(HpStatus))]
    private int _maxHp = 100;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(MpPercent))]
    [NotifyPropertyChangedFor(nameof(MpStatus))]
    private int _currentMp = 50;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(MpPercent))]
    [NotifyPropertyChangedFor(nameof(MpStatus))]
    private int _maxMp = 50;

    [ObservableProperty] private string _currentLocation = "Загрузка...";
    [ObservableProperty] private string _automationStatus = "Автоматизация: ВЫКЛ";
    [ObservableProperty] private ObservableCollection<string> _eventLog = new();

    public double HpPercent => MaxHp > 0 ? (double)CurrentHp / MaxHp : 0;
    public double MpPercent => MaxMp > 0 ? (double)CurrentMp / MaxMp : 0;
    public string HpStatus => $"{CurrentHp} / {MaxHp}";
    public string MpStatus => $"{CurrentMp} / {MaxMp}";

    private bool _isAutomationOn = false;

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
        EventLog.Insert(0, $"[{DateTime.Now:HH:mm:ss}] {message}");
        if (EventLog.Count > 20)
        {
            EventLog.RemoveAt(EventLog.Count - 1);
        }
    }

    [RelayCommand] private async Task MoveNorth() => await MoveAsync("north");
    [RelayCommand] private async Task MoveSouth() => await MoveAsync("south");
    [RelayCommand] private async Task MoveWest()  => await MoveAsync("west");
    [RelayCommand] private async Task MoveEast()  => await MoveAsync("east");

    private async Task MoveAsync(string direction) {
        AddLogEvent($"Движение на {direction}...");
        await Task.Delay(200);
        AddLogEvent($"Вы переместились на {direction}");
    }

    [RelayCommand] private void ToggleAutomation() {
        _isAutomationOn = !_isAutomationOn;
        AutomationStatus = _isAutomationOn ? "Автоматизация: ВКЛ" : "Автоматизация: ВЫКЛ";
        AddLogEvent(AutomationStatus);
    }

    [RelayCommand] private async Task OpenMap() => await Shell.Current.GoToAsync("///map");
    [RelayCommand] private async Task OpenCharacter() => await Shell.Current.GoToAsync("///character");
    [RelayCommand] private async Task OpenProfiles() => await Shell.Current.GoToAsync("///profiles");
    [RelayCommand] private async Task OpenAutomation() => await Shell.Current.GoToAsync("///automation");
    [RelayCommand] private async Task OpenSettings() => await Shell.Current.GoToAsync("///settings");
}
