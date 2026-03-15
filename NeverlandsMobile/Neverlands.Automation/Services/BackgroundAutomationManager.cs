using Neverlands.Core.Interfaces;
using Neverlands.Core.Models;

namespace Neverlands.Automation.Services;

public class BackgroundAutomationManager : IBackgroundAutomationManager
{
    private readonly List<AutomationTask> _tasks = new();
    private CancellationTokenSource? _cts;
    private bool _isRunning;

    public bool IsRunning => _isRunning;

    public event EventHandler<AutomationTask>? TaskTriggered;

    public void Start()
    {
        if (_isRunning) return;
        _isRunning = true;
        _cts = new CancellationTokenSource();
        Task.Run(() => RunAutomationLoop(_cts.Token));
    }

    public void Stop()
    {
        _isRunning = false;
        _cts?.Cancel();
    }

    public void AddTask(AutomationTask task)
    {
        lock (_tasks)
        {
            _tasks.Add(task);
            _tasks.Sort((a, b) => a.TriggerTime.CompareTo(b.TriggerTime));
        }
    }

    public void RemoveTask(Guid taskId)
    {
        lock (_tasks)
        {
            _tasks.RemoveAll(t => t.Id == taskId);
        }
    }

    public IEnumerable<AutomationTask> GetTasks()
    {
        lock (_tasks)
        {
            return _tasks.ToList();
        }
    }

    private async Task RunAutomationLoop(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            List<AutomationTask> toExecute = new();
            var now = DateTime.Now;

            lock (_tasks)
            {
                for (int i = 0; i < _tasks.Count; i++)
                {
                    if (_tasks[i].TriggerTime <= now && !_tasks[i].IsCompleted)
                    {
                        toExecute.Add(_tasks[i]);
                    }
                }
            }

            foreach (var task in toExecute)
            {
                TaskTriggered?.Invoke(this, task);

                if (task.IsRecurring)
                {
                    task.TriggerTime = now.AddMinutes(task.RecurrenceIntervalMinutes);
                }
                else
                {
                    task.IsCompleted = true;
                }
            }

            if (!toExecute.Any())
            {
                await Task.Delay(5000, token);
            }
            else
            {
                lock (_tasks)
                {
                    _tasks.Sort((a, b) => a.TriggerTime.CompareTo(b.TriggerTime));
                }
            }
        }
    }
}
