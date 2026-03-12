namespace Neverlands.Core.Models;
public class GameCell {
    public string RegNum { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public int Cost { get; set; } = 30;
    public DateTime Visited { get; set; }
}
