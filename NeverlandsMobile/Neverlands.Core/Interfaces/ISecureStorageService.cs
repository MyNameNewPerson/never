namespace Neverlands.Core.Interfaces;

public interface ISecureStorageService
{
    Task SaveCredentialAsync(string key, string value);
    Task<string?> GetCredentialAsync(string key);
    void RemoveCredential(string key);
}
