using Neverlands.Core.Interfaces;
using Microsoft.Maui.Storage;

namespace Neverlands.Infrastructure.Services;

public class SecureStorageService : ISecureStorageService
{
    public async Task SaveCredentialAsync(string key, string value)
    {
        await SecureStorage.Default.SetAsync(key, value);
    }

    public async Task<string?> GetCredentialAsync(string key)
    {
        return await SecureStorage.Default.GetAsync(key);
    }

    public void RemoveCredential(string key)
    {
        SecureStorage.Default.Remove(key);
    }
}
