namespace Neverlands.Core.Interfaces;

public interface IAntiCaptchaService
{
    Task<string?> SolveCaptchaAsync(byte[] imageBytes);
}
