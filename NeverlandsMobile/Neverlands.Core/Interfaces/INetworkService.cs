namespace Neverlands.Core.Interfaces;

public interface INetworkService
{
    Task<string?> GetAsync(string url);
    Task<string?> PostAsync(string url, string content);
}
