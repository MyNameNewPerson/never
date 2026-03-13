using Neverlands.Core.Models;
using Neverlands.Core.Interfaces;
using System.Text.RegularExpressions;

namespace Neverlands.Automation.Services;

public class ResourceAutomationService : IResourceAutomationService
{
    private readonly INetworkService _networkService;
    private readonly IAntiCaptchaService _antiCaptchaService;

    public bool IsAutoFishingEnabled { get; set; }
    public bool IsAutoMiningEnabled { get; set; }
    public bool IsAutoWoodcuttingEnabled { get; set; }

    public ResourceAutomationService(INetworkService networkService, IAntiCaptchaService antiCaptchaService)
    {
        _networkService = networkService;
        _antiCaptchaService = antiCaptchaService;
    }

    public async Task ProcessAutomationAsync(GameState state, UserProfile profile)
    {
        if (state.IsInCombat) return;

        if (IsAutoFishingEnabled)
        {
            await HandleFishingAsync(state);
        }
        else if (IsAutoWoodcuttingEnabled)
        {
            await HandleWoodcuttingAsync(state);
        }
    }

    private async Task HandleFishingAsync(GameState state)
    {
        // Ported logic from ScriptManager.cs and FormMain.cs
        // 1. Check if we are at a fishing spot (from GameState/Cell metadata)
        // 2. Check if we need to throw the rod
        // 3. Handle captcha if it appears

        var mainPage = await _networkService.GetAsync("http://www.neverlands.ru/main.php");
        if (string.IsNullOrEmpty(mainPage)) return;

        if (mainPage.Contains("inventory.php?inv=1")) // Simplified check for "throw rod" link
        {
            await _networkService.GetAsync("http://www.neverlands.ru/main.php?get_id=18"); // Example fishing action ID
        }
    }

    private async Task HandleWoodcuttingAsync(GameState state)
    {
        var mainPage = await _networkService.GetAsync("http://www.neverlands.ru/main.php");
        if (string.IsNullOrEmpty(mainPage)) return;

        // "Срубить" or "Срезать" logic
        var match = Regex.Match(mainPage, @"main\.php\?get_id=([0-9]+)&act=([0-9]+)&vcode=([a-z0-9]+)");
        if (match.Success)
        {
            await _networkService.GetAsync($"http://www.neverlands.ru/{match.Value}");
        }
    }
}
