namespace Neverlands.Core.Models;
public class UserProfile {
    public string Nickname { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FlashToken { get; set; } = string.Empty;
    public bool AutoLogon { get; set; }
    public int HealThresholdHp { get; set; } = 50;
    public int HealThresholdMa { get; set; } = 50;
    public bool AutoCure { get; set; }
    public string AntiCaptchaKey { get; set; } = string.Empty;
    public string LastKnownLocation { get; set; } = "0-000";
}
