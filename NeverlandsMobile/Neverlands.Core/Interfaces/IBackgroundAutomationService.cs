namespace Neverlands.Core.Interfaces;
public interface IBackgroundAutomationService {
    void Start();
    void Stop();
    bool IsRunning { get; }
}
