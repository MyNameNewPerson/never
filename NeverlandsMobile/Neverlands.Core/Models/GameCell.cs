namespace Neverlands.Core.Models;

public class GameCell {
    public string RegNum { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string Tooltip { get; set; } = string.Empty;
    public int Cost { get; set; } = 30;
    public bool HasFish { get; set; }
    public bool HasWater { get; set; }
    public string HerbGroup { get; set; } = string.Empty;
    public List<MapBot> Bots { get; set; } = new();
    public DateTime Visited { get; set; }
    public bool IsTeleport { get; set; }
}
