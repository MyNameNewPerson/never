namespace Neverlands.Core.Models.Combat;

public class CombatBotGroup
{
    public int Id { get; set; }
    public int MinimalLevel { get; set; }
    public bool DoHits { get; set; } = true;
    public bool DoBlocks { get; set; } = true;
    public bool DoMagHits { get; set; } = true;
    public bool DoMagBlocks { get; set; } = false;
    public bool DoRestoreHp { get; set; } = true;
    public bool DoRestoreMa { get; set; } = true;
    public int RestoreHpThreshold { get; set; } = 50;
    public int RestoreMaThreshold { get; set; } = 50;
    public int MagHits { get; set; } = 5;
    public int[] SpellsHits { get; set; } = CombatSpellConstants.Hits;
    public int[] SpellsBlocks { get; set; } = CombatSpellConstants.Blocks;
    public int[] SpellsRestoreHp { get; set; } = CombatSpellConstants.RestoreHp;
    public int[] SpellsRestoreMa { get; set; } = CombatSpellConstants.RestoreMa;
    public int[] SpellsMisc { get; set; } = Array.Empty<int>();
}
