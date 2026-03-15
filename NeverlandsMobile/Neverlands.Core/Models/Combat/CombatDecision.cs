namespace Neverlands.Core.Models.Combat;

public class CombatDecision
{
    public bool IsInCombat { get; set; }
    public bool IsMyTurn { get; set; }
    public string? PostData { get; set; }
    public string? Message { get; set; }
    public Dictionary<int, int> Cooldowns { get; set; } = new();
    public List<string> ActiveBuffs { get; set; } = new();
}
