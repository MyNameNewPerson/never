using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;
using System.Collections.ObjectModel;

namespace Neverlands.Mobile.ViewModels;

public partial class AutomationViewModel : ObservableObject
{
    private readonly IBackgroundAutomationManager _automationManager;
    private readonly IScriptManager _scriptManager;

    [ObservableProperty] private bool _isAutomationEnabled;
    [ObservableProperty] private bool _isAutoCombatEnabled;
    [ObservableProperty] private bool _isResourceGatheringEnabled;
    [ObservableProperty] private string _currentTaskStatus = "Ожидание...";

    public ObservableCollection<GameScript> Scripts { get; } = new();

    public AutomationViewModel(IBackgroundAutomationManager automationManager, IScriptManager scriptManager)
    {
        _automationManager = automationManager;
        _scriptManager = scriptManager;
        IsAutomationEnabled = _automationManager.IsRunning;
        LoadScripts();
    }

    private void LoadScripts()
    {
        Scripts.Clear();
        // In a real implementation, these would be loaded from a configuration file or service
        Scripts.Add(new GameScript { Name = "Авто-лекарь", Action = "drinkpotion", Parameter = "100" });
        Scripts.Add(new GameScript { Name = "Сбор ресурсов (Лес)", Action = "startresource", Parameter = "woodcutting" });
        Scripts.Add(new GameScript { Name = "Сбор ресурсов (Шахта)", Action = "startresource", Parameter = "mining" });
    }

    [RelayCommand]
    private async Task RunScriptAsync(GameScript script)
    {
        CurrentTaskStatus = $"Запущен скрипт: {script.Name}";
        try
        {
            // Note: In Phase 1, we don't have a full UserProfile context here, so we use a temporary one or wait for Phase 2
            // For now, we simulate the execution.
            await Task.Delay(1000);
            CurrentTaskStatus = $"Скрипт {script.Name} выполнен";
        }
        catch (Exception ex)
        {
            CurrentTaskStatus = $"Ошибка скрипта: {ex.Message}";
        }
    }

    partial void OnIsAutomationEnabledChanged(bool value)
    {
        if (value == _automationManager.IsRunning) return;

        CurrentTaskStatus = value ? "Автоматизация активирована" : "Автоматизация остановлена";
        if (value)
        {
            _automationManager.Start();
        }
        else
        {
            _automationManager.Stop();
        }
    }
}

public class GameScript
{
    public string Name { get; set; } = string.Empty;
    public string Action { get; set; } = string.Empty;
    public string Parameter { get; set; } = string.Empty;
}
