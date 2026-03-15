using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;
using Neverlands.Core;

namespace Neverlands.Automation.Services;

public class ResourceAutomationService : IResourceAutomationService
{
    private readonly INetworkService _networkService;
    private readonly IAntiCaptchaService _antiCaptchaService;
    private readonly IBackgroundAutomationManager _backgroundManager;
    private bool _isRunning;

    public ResourceAutomationService(
        INetworkService networkService,
        IAntiCaptchaService antiCaptchaService,
        IBackgroundAutomationManager backgroundManager)
    {
        _networkService = networkService;
        _antiCaptchaService = antiCaptchaService;
        _backgroundManager = backgroundManager;
    }

    public bool IsRunning => _isRunning;

    public async Task StartWoodcuttingAsync()
    {
        _isRunning = true;
        _backgroundManager.AddTask(new AutomationTask
        {
            Action = "woodcutting_internal",
            Parameter = "",
            TriggerTime = DateTime.Now,
            IsRecurring = true,
            RecurrenceIntervalMinutes = 1,
            Description = "Auto Woodcutting"
        });
        await Task.CompletedTask;
    }

    public async Task ExecuteWoodcuttingStepAsync()
    {
        await ExecuteGenericResourceStepAsync("wood");
    }

    public async Task StartFishingAsync()
    {
        _isRunning = true;
        _backgroundManager.AddTask(new AutomationTask
        {
            Action = "fishing_internal",
            Parameter = "",
            TriggerTime = DateTime.Now,
            IsRecurring = true,
            RecurrenceIntervalMinutes = 1,
            Description = "Auto Fishing"
        });
        await Task.CompletedTask;
    }

    public async Task ExecuteFishingStepAsync()
    {
        await ExecuteGenericResourceStepAsync("fish");
    }

    public async Task StartMiningAsync()
    {
        _isRunning = true;
        _backgroundManager.AddTask(new AutomationTask
        {
            Action = "mining_internal",
            Parameter = "",
            TriggerTime = DateTime.Now,
            IsRecurring = true,
            RecurrenceIntervalMinutes = 1,
            Description = "Auto Mining"
        });
        await Task.CompletedTask;
    }

    public async Task ExecuteMiningStepAsync()
    {
        await ExecuteGenericResourceStepAsync("mine");
    }

    private async Task ExecuteGenericResourceStepAsync(string resourceType)
    {
        var imageBytes = await _networkService.GetAsync(GameConstants.CaptchaUrl, true);
        if (imageBytes != null && imageBytes.Length > 0)
        {
            var code = await _antiCaptchaService.SolveCaptchaAsync(imageBytes);
            if (!string.IsNullOrEmpty(code))
            {
                await _networkService.PostAsync(GameConstants.MainPhp, $"vcode={code}");
            }
        }
        else
        {
            await _networkService.GetAsync($"{GameConstants.MainPhp}?v={resourceType}");
        }
    }

    public void StopAutomation()
    {
        _isRunning = false;
    }
}
