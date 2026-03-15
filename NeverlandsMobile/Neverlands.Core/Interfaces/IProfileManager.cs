using Neverlands.Core.Models;

namespace Neverlands.Core.Interfaces;

public interface IProfileManager
{
    Task LoadProfilesAsync();
    Task SaveProfilesAsync();
    void AddProfile(UserProfile profile);
    void DeleteProfile(string nickname);
    void SwitchProfile(string nickname);
    UserProfile? GetActiveProfile();
    IEnumerable<UserProfile> GetAllProfiles();
}
