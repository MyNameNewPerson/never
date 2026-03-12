using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Models;
using Neverlands.Core.Interfaces;

namespace Neverlands.Mobile.ViewModels;

public partial class MainViewModel : ObservableObject {
    private readonly ICombatService _combatService;
    private readonly INavigationService _navigationService;

    [ObservableProperty] private GameState _state = new();
    [ObservableProperty] private string _statusMessage = "Ready";

    public MainViewModel(ICombatService combatService, INavigationService navigationService) {
        _combatService = combatService;
        _navigationService = navigationService;
    }

    [RelayCommand] private async Task StartAutomation() {
        StatusMessage = "Automation Running...";
        await Task.CompletedTask;
    }

    [RelayCommand] private void StopAutomation() { StatusMessage = "Automation Stopped"; }

    [RelayCommand]
    private async Task NavigateToMap()
    {
        await Shell.Current.GoToAsync("MapPage");
    }

    [RelayCommand]
    private async Task NavigateToProfiles()
    {
        await Shell.Current.GoToAsync("ProfilesPage");
    }

    [RelayCommand]
    private async Task NavigateToSettings()
    {
        await Shell.Current.GoToAsync("SettingsPage");
    }
}
