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
        LoadScripts();
    }

    private void LoadScripts()
    {
        Scripts.Clear();
        Scripts.Add(new GameScript { Name = "Авто-лекарь" });
        Scripts.Add(new GameScript { Name = "Маршрут в город" });
        Scripts.Add(new GameScript { Name = "Проверка почты" });
    }

    [RelayCommand]
    private async Task RunScriptAsync(GameScript script)
    {
        CurrentTaskStatus = $"Запущен скрипт: {script.Name}";
        await Task.Delay(2000);
        CurrentTaskStatus = "Скрипт выполнен успешно";
    }

    partial void OnIsAutomationEnabledChanged(bool value)
    {
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
}
