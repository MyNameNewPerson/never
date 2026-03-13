using System.Net;
using System.Text;
using Neverlands.Core.Interfaces;

namespace Neverlands.Infrastructure.Services;

public class NetworkService : INetworkService {
    private readonly HttpClient _httpClient;
    private readonly CookieContainer _cookieContainer;
    public NetworkService() {
        _cookieContainer = new CookieContainer();
        var handler = new HttpClientHandler {
            CookieContainer = _cookieContainer,
            UseCookies = true,
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
        };
        _httpClient = new HttpClient(handler);
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "NeverlandsMobileClient/1.0");
        _httpClient.Timeout = TimeSpan.FromSeconds(15);
    }
    public async Task<string?> GetAsync(string url) {
        return await ExecuteWithRetry(async () => {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var bytes = await response.Content.ReadAsByteArrayAsync();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            return Encoding.GetEncoding(1251).GetString(bytes);
        });
    }
    public async Task<string?> PostAsync(string url, string content) {
        return await ExecuteWithRetry(async () => {
            var httpContent = new StringContent(content, Encoding.GetEncoding(1251), "application/x-www-form-urlencoded");
            var response = await _httpClient.PostAsync(url, httpContent);
            response.EnsureSuccessStatusCode();
            var bytes = await response.Content.ReadAsByteArrayAsync();
            return Encoding.GetEncoding(1251).GetString(bytes);
        });
    }
    private async Task<string?> ExecuteWithRetry(Func<Task<string?>> action, int retries = 3) {
        for (int i = 0; i < retries; i++) {
            try { return await action(); }
            catch (Exception) {
                if (i == retries - 1) return null;
                await Task.Delay(1000 * (i + 1));
            }
        }
        return null;
    }
}
