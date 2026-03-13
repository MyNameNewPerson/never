using Neverlands.Core.Models;

namespace Neverlands.Core.Interfaces;

public interface IBackgroundAutomationManager
{
    void Start();
    void Stop();
    bool IsRunning { get; }

    void AddTask(AutomationTask task);
    void RemoveTask(Guid taskId);
    IEnumerable<AutomationTask> GetTasks();

    event EventHandler<AutomationTask>? TaskTriggered;
}
