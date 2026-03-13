namespace Neverlands.Core.Models.Combat;

public static class CombatSpellConstants
{
    public static readonly int[] Hits = { 269, 37, 56, 205, 208, 122, 94, 144, 148, 81, 124, 206, 207, 86, 123, 184, 146 };
    public static readonly int[] Blocks = { 267, 271, 57, 258, 142, 181, 380 };
    public static readonly int[] RestoreHp = { 265, 73, 223, 84, 162, 385, 388, 320, 32, 287, 520, 309, 486, 337, 483 };
    public static readonly int[] RestoreMa = { 85, 33, 306, 521, 309, 337 };

    public static readonly int[] DefaultOdCosts = new int[522];
    public static readonly int[] DefaultManaCosts = new int[522];
    public static readonly int[] PosType = new int[522];

    static CombatSpellConstants()
    {
        // OD Costs (simplified subset for now, following desktop Od array pattern)
        for (int i = 0; i < 522; i++) { DefaultOdCosts[i] = 100; DefaultManaCosts[i] = 50; }
        DefaultOdCosts[0] = 0; DefaultOdCosts[1] = 0; DefaultOdCosts[2] = 50; DefaultOdCosts[3] = 90;
        DefaultOdCosts[32] = 30; DefaultOdCosts[33] = 30;

        // Mana Costs
        DefaultManaCosts[0] = 0; DefaultManaCosts[1] = 0; DefaultManaCosts[2] = 5; DefaultManaCosts[3] = 5;

        // Position Types: 1=Hit, 2=Block, 3=Magic, 4=Misc
        PosType[0] = 1; PosType[1] = 1; PosType[2] = 1; PosType[3] = 1;
        for (int i = 4; i <= 31; i++) PosType[i] = 2;
        PosType[32] = 4; PosType[33] = 4;
    }

    public static bool IsPhHit(int code) => code >= 0 && code <= 1;
    public static bool IsMagHit(int code) => code >= 2 && code <= 3;
    public static bool IsPhBlock(int code) => code >= 4 && code <= 28;
}
