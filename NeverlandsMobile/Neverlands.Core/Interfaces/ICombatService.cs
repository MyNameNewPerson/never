using Neverlands.Core.Models;
namespace Neverlands.Core.Interfaces;
public class CombatDecision {
    public bool IsInCombat { get; set; }
    public bool IsMyTurn { get; set; }
    public string PostData { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}
public interface ICombatService {
    CombatDecision AnalyzeFight(string html, UserProfile profile);
}
