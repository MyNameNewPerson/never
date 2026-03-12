namespace Neverlands.Core.Models.Combat;
public class CombatBotGroup {
    public int Id { get; set; }
    public int MinimalLevel { get; set; }
    public bool DoHits { get; set; } = true;
    public bool DoBlocks { get; set; } = true;
    public bool DoMagHits { get; set; } = true;
    public bool DoMagBlocks { get; set; } = false;
    public int MagHits { get; set; } = 5;
    public int[] SpellsHits { get; set; } = Array.Empty<int>();
    public int[] SpellsBlocks { get; set; } = Array.Empty<int>();
    public int[] SpellsRestoreHp { get; set; } = Array.Empty<int>();
    public int[] SpellsRestoreMa { get; set; } = Array.Empty<int>();
    public int[] SpellsMisc { get; set; } = Array.Empty<int>();
}
