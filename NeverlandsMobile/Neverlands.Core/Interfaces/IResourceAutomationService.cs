using Neverlands.Core.Models;

namespace Neverlands.Core.Interfaces;

public interface IResourceAutomationService
{
    bool IsAutoFishingEnabled { get; set; }
    bool IsAutoMiningEnabled { get; set; }
    bool IsAutoWoodcuttingEnabled { get; set; }

    Task ProcessAutomationAsync(GameState state, UserProfile profile);
}
