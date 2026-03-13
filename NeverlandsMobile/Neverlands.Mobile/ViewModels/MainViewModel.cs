using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Models;
using Neverlands.Core.Interfaces;
using Neverlands.Automation.Services;

namespace Neverlands.Mobile.ViewModels;

public partial class MainViewModel : ObservableObject {
    private readonly AutomationEngine _automationEngine;
    private readonly IProfileManager _profileManager;

    [ObservableProperty] private GameState _state = new();
    [ObservableProperty] private string _statusMessage = "Ready";

    public MainViewModel(AutomationEngine automationEngine, IProfileManager profileManager) {
        _automationEngine = automationEngine;
        _profileManager = profileManager;
    }

    [RelayCommand] private void StartAutomation() {
        StatusMessage = "Automation Running...";
        _automationEngine.StartAutomation();
    }

    [RelayCommand] private void StopAutomation() {
        StatusMessage = "Automation Stopped";
        _automationEngine.StopAutomation();
    }
}
