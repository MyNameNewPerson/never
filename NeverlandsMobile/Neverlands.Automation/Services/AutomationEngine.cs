using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using Neverlands.Core;

namespace Neverlands.Automation.Services;

public class AutomationEngine
{
    private readonly IBackgroundAutomationManager? _backgroundManager;
    private readonly IScriptManager? _scriptManager;
    private readonly INetworkService _networkService;
    private readonly ICombatService _combatService;
    private readonly IProfileManager? _profileManager;

    public AutomationEngine(
        IBackgroundAutomationManager? backgroundManager,
        IScriptManager? scriptManager,
        INetworkService networkService,
        ICombatService combatService,
        IProfileManager? profileManager)
    {
        _backgroundManager = backgroundManager;
        _scriptManager = scriptManager;
        _networkService = networkService;
        _combatService = combatService;
        _profileManager = profileManager;
        if (_backgroundManager != null)
            _backgroundManager.TaskTriggered += OnTaskTriggered;
    }

    public void StartAutomation()
    {
        _backgroundManager?.Start();
    }

    public void StopAutomation()
    {
        _backgroundManager?.Stop();
    }

    private async void OnTaskTriggered(object? sender, AutomationTask task)
    {
        var profile = _profileManager?.GetActiveProfile();
        if (profile != null && _scriptManager != null)
        {
            await _scriptManager.ExecuteActionAsync(task.Action, task.Parameter, profile);
        }
    }

    public async Task ProcessGameStateAsync(string html, UserProfile profile)
    {
        var combatDecision = _combatService.AnalyzeFight(html, profile);
        if (combatDecision.IsInCombat && combatDecision.IsMyTurn)
        {
            await _networkService.PostAsync(GameConstants.MainPhp, combatDecision.PostData ?? "");
        }
    }
}
