namespace Neverlands.Core.Models.Combat;
public class CombatSpell {
    public int Id { get; }
    public string Name { get; }
    public CombatSpell(int id, string name) { Id = id; Name = name; }
    public static bool IsPhBlock(int code) => code >= 4 && code <= 28;
    public static bool IsMagBlock(int code) => code >= 29 && code <= 31;
    public static bool IsPhHit(int code) => code >= 0 && code <= 1;
    public static bool IsMagHit(int code) => code >= 2 && code <= 3;
    public static bool IsScrollHit(int code) => code == 277 || code == 338;
}
