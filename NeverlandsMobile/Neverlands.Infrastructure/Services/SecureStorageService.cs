using Neverlands.Core.Interfaces;
#if !DEBUG || ANDROID || IOS || WINDOWS
using Microsoft.Maui.Storage;
#endif

namespace Neverlands.Infrastructure.Services;

public class SecureStorageService : ISecureStorageService
{
    private const string LoginKey = "user_login";
    private const string PasswordKey = "user_password";

    public async Task SaveCredentialsAsync(string login, string password)
    {
#if !DEBUG || ANDROID || IOS || WINDOWS
        try
        {
            await SecureStorage.Default.SetAsync(LoginKey, login);
            await SecureStorage.Default.SetAsync(PasswordKey, password);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"SecureStorage error: {ex.Message}");
        }
#endif
        await Task.CompletedTask;
    }

    public async Task<(string Login, string Password)> GetCredentialsAsync()
    {
#if !DEBUG || ANDROID || IOS || WINDOWS
        try
        {
            var login = await SecureStorage.Default.GetAsync(LoginKey) ?? string.Empty;
            var password = await SecureStorage.Default.GetAsync(PasswordKey) ?? string.Empty;
            return (login, password);
        }
        catch (Exception)
        {
            return (string.Empty, string.Empty);
        }
#else
        return await Task.FromResult((string.Empty, string.Empty));
#endif
    }

    public async Task ClearCredentialsAsync()
    {
#if !DEBUG || ANDROID || IOS || WINDOWS
        SecureStorage.Default.Remove(LoginKey);
        SecureStorage.Default.Remove(PasswordKey);
#endif
        await Task.CompletedTask;
    }

    public async Task SaveTokenAsync(string key, string token)
    {
#if !DEBUG || ANDROID || IOS || WINDOWS
        await SecureStorage.Default.SetAsync(key, token);
#endif
        await Task.CompletedTask;
    }

    public async Task<string?> GetTokenAsync(string key)
    {
#if !DEBUG || ANDROID || IOS || WINDOWS
        return await SecureStorage.Default.GetAsync(key);
#else
        return null;
#endif
    }
}
