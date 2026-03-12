namespace Neverlands.Core.Models;
public class GameState {
    public string CurrentLocation { get; set; } = "0-000";
    public int TirednessPercentage { get; set; }
    public double CurrentHp { get; set; }
    public int MaxHp { get; set; }
    public double CurrentMa { get; set; }
    public int MaxMa { get; set; }
    public bool IsInCombat { get; set; }
    public string ActiveCaptcha { get; set; } = string.Empty;
}
