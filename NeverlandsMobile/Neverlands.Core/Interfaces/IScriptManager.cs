using Neverlands.Core.Models;

namespace Neverlands.Core.Interfaces;

public interface IScriptManager
{
    Task ExecuteActionAsync(string action, string parameter, UserProfile profile);
    string GetStatus();
}
