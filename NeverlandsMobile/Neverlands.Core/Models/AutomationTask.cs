namespace Neverlands.Core.Models;

public class AutomationTask
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Description { get; set; } = string.Empty;
    public DateTime TriggerTime { get; set; }
    public bool IsRecurring { get; set; }
    public int RecurrenceIntervalMinutes { get; set; }
    public string Action { get; set; } = string.Empty; // e.g., "DrinkPotion", "MoveTo", "WearComplect"
    public string Parameter { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}
