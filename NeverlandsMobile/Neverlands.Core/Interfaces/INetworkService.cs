namespace Neverlands.Core.Interfaces;

public interface INetworkService
{
    Task<string?> GetAsync(string url);
    Task<byte[]?> GetAsync(string url, bool returnBytes);
    Task<string?> PostAsync(string url, string content);
}
