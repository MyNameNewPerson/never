using Neverlands.Core.Interfaces;
using Newtonsoft.Json;

namespace Neverlands.Infrastructure.Services;

public class SecureStorageService : ISecureStorageService
{
    private const string CacheKey = "SecureStorage_FallbackCache";

    public async Task SaveCredentialAsync(string key, string value)
    {
        // For migration/testing purposes, using file-based storage as default to avoid MAUI dependency issues in dev environments.
        // In final mobile production, this should be wrapped in #if ANDROID/IOS and use Microsoft.Maui.Storage.SecureStorage.
        var cache = await GetFallbackCache();
        cache[key] = value;
        await SaveFallbackCache(cache);
    }

    public async Task<string?> GetCredentialAsync(string key)
    {
        var cache = await GetFallbackCache();
        return cache.TryGetValue(key, out var value) ? value : null;
    }

    public void RemoveCredential(string key)
    {
        var cache = GetFallbackCache().Result;
        if (cache.Remove(key))
        {
            SaveFallbackCache(cache).Wait();
        }
    }

    private async Task<Dictionary<string, string>> GetFallbackCache()
    {
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "secure_storage.json");
        if (File.Exists(path))
        {
            var json = await File.ReadAllTextAsync(path);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json) ?? new();
        }
        return new();
    }

    private async Task SaveFallbackCache(Dictionary<string, string> cache)
    {
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "secure_storage.json");
        var json = JsonConvert.SerializeObject(cache);
        await File.WriteAllTextAsync(path, json);
    }
}
