using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;
using System.Collections.ObjectModel;
using System.Text;

namespace Neverlands.Mobile.ViewModels;

public partial class AutomationViewModel : ObservableObject
{
    private readonly IBackgroundAutomationManager _automationManager;
    private readonly IScriptManager _scriptManager;

    [ObservableProperty] private bool _isAutomationRunning;
    [ObservableProperty] private bool _isResourceFarmingEnabled;
    [ObservableProperty] private bool _isAutoCombatEnabled;
    [ObservableProperty] private string _currentTaskDescription = "Нет активных задач";
    [ObservableProperty] private string _automationLog = string.Empty;
    [ObservableProperty] private ObservableCollection<GameScript> _scripts = new();

    private StringBuilder _logBuilder = new StringBuilder();

    public AutomationViewModel(IBackgroundAutomationManager automationManager, IScriptManager scriptManager)
    {
        _automationManager = automationManager;
        _scriptManager = scriptManager;
        LoadScripts();
    }

    private void LoadScripts()
    {
        Scripts = new ObservableCollection<GameScript>(_scriptManager.GetAllScripts());
    }

    private void AddLog(string message)
    {
        _logBuilder.Insert(0, $"[{DateTime.Now:HH:mm:ss}] {message}\n");
        AutomationLog = _logBuilder.ToString();
    }

    [RelayCommand]
    private async Task RunScript(GameScript script)
    {
        if (script == null) return;
        CurrentTaskDescription = $"Выполнение: {script.Name}";
        AddLog($"Запущен скрипт {script.Name}");
        await Task.Delay(1000); // Simulation
    }

    [RelayCommand]
    private void StopScript()
    {
        CurrentTaskDescription = "Все задачи остановлены";
        AddLog("Остановка всех скриптов");
    }

    partial void OnIsAutomationRunningChanged(bool value)
    {
        if (value)
        {
            _automationManager.Start();
            AddLog("Фоновая служба запущена");
        }
        else
        {
            _automationManager.Stop();
            AddLog("Фоновая служба остановлена");
        }
    }
}
