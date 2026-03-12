namespace Neverlands.Core.Interfaces;

public interface ISecureStorageService
{
    Task SaveCredentialsAsync(string login, string password);
    Task<(string Login, string Password)> GetCredentialsAsync();
    Task ClearCredentialsAsync();
    Task SaveTokenAsync(string key, string token);
    Task<string?> GetTokenAsync(string key);
}
