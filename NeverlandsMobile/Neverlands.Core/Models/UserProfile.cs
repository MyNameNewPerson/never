namespace Neverlands.Core.Models;
public class UserProfile {
    public string Id => Nickname;
    public string Nickname { get; set; } = string.Empty;
    public string Login => Nickname;
    public string Password { get; set; } = string.Empty;
    public string FlashToken { get; set; } = string.Empty;
    public bool AutoLogon { get; set; }
    public bool AutoLogin => AutoLogon;
    public bool RememberPassword { get; set; } = true;
    public bool IsActive { get; set; }
    public int HealThresholdHp { get; set; } = 50;
    public int HealThresholdMa { get; set; } = 50;
    public bool AutoCure { get; set; }
    public string AntiCaptchaKey { get; set; } = string.Empty;
    public string LastKnownLocation { get; set; } = "0-000";
    public DateTime LastLogin { get; set; } = DateTime.Now; // Added for ProfilesPage requirement
}
