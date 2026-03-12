namespace Neverlands.Core.Models.Combat;
public static class CombatSpellConstants {
    public static readonly int[] Hits = { 269, 37, 56, 205, 208, 122, 94, 144, 148, 81, 124, 206, 207, 86, 123, 184, 146 };
    public static readonly int[] Blocks = { 267, 271, 57, 258, 142, 181, 380 };
    public static readonly int[] DefaultOdCosts = new int[522];
    public static readonly int[] DefaultManaCosts = new int[522];
    static CombatSpellConstants() {
        DefaultOdCosts[0] = 0; DefaultOdCosts[1] = 0; DefaultOdCosts[2] = 50; DefaultOdCosts[3] = 90;
    }
}
