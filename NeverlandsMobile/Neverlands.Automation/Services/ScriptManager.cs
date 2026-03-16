using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using Neverlands.Core;

namespace Neverlands.Automation.Services;

public class ScriptManager : IScriptManager
{
    private readonly INavigationService _navigationService;
    private readonly ICombatService _combatService;
    private readonly IResourceAutomationService _resourceAutomationService;
    private readonly INetworkService _networkService;

    public ScriptManager(
        INavigationService navigationService,
        ICombatService combatService,
        IResourceAutomationService resourceAutomationService,
        INetworkService networkService)
    {
        _navigationService = navigationService;
        _combatService = combatService;
        _resourceAutomationService = resourceAutomationService;
        _networkService = networkService;
    }

    public async Task ExecuteActionAsync(string action, string parameter, UserProfile profile)
    {
        if (_resourceAutomationService is not ResourceAutomationService ras) return;

        switch (action.ToLower())
        {
            case "moveto":
                await _navigationService.MoveToAsync(profile.LastKnownLocation ?? "0-000", parameter);
                break;
            case "drinkpotion":
                await _networkService.GetAsync($"{GameConstants.ItemPhp}?use={parameter}");
                break;
            case "wearcomplect":
                await _networkService.GetAsync($"{GameConstants.InventoryPhp}?wear_set={parameter}");
                break;
            case "startresource":
                if (parameter.ToLower() == "woodcutting")
                    await _resourceAutomationService.StartWoodcuttingAsync();
                else if (parameter.ToLower() == "mining")
                    await _resourceAutomationService.StartMiningAsync();
                else if (parameter.ToLower() == "fishing")
                    await _resourceAutomationService.StartFishingAsync();
                break;
            case "stopresource":
                _resourceAutomationService.StopAutomation();
                break;
            case "woodcutting_internal":
                await ras.ExecuteWoodcuttingStepAsync();
                break;
            case "mining_internal":
                await ras.ExecuteMiningStepAsync();
                break;
            case "fishing_internal":
                await ras.ExecuteFishingStepAsync();
                break;
        }
    }

    public string GetStatus()
    {
        return "Script engine ready";
    }

    public IEnumerable<GameScript> GetAllScripts()
    {
        return new List<GameScript>
        {
            new GameScript { Name = "Авто-лекарь" },
            new GameScript { Name = "Маршрут в город" },
            new GameScript { Name = "Проверка почты" }
        };
    }
}
