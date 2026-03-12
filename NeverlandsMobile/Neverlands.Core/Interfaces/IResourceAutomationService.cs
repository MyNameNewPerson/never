namespace Neverlands.Core.Interfaces;

public interface IResourceAutomationService
{
    Task StartWoodcuttingAsync();
    Task StartFishingAsync();
    Task StartMiningAsync();
    void StopAutomation();
    bool IsRunning { get; }
}
