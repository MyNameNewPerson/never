using Neverlands.Core.Models;
using Neverlands.Core.Interfaces;

namespace Neverlands.Automation.Services;

public class ResourceAutomationService : IResourceAutomationService
{
    public bool IsAutoFishingEnabled { get; set; }
    public bool IsAutoMiningEnabled { get; set; }
    public bool IsAutoWoodcuttingEnabled { get; set; }

    public ResourceAutomationService()
    {
    }

    public async Task ProcessAutomationAsync(GameState state, UserProfile profile)
    {
        await Task.CompletedTask;
    }
}
