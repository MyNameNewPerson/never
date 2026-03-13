using Neverlands.Core.Models;
using Neverlands.Core.Interfaces;
using Newtonsoft.Json;

namespace Neverlands.Infrastructure.Services;

public class ProfileManager : IProfileManager
{
    private readonly ISecureStorageService _secureStorage;
    private const string ProfilesKey = "Neverlands_Profiles";
    private List<UserProfile> _profiles = new();
    private UserProfile? _activeProfile;

    public ProfileManager(ISecureStorageService secureStorage)
    {
        _secureStorage = secureStorage;
    }

    public async Task LoadProfilesAsync()
    {
        var json = await _secureStorage.GetCredentialAsync(ProfilesKey);
        if (!string.IsNullOrEmpty(json))
        {
            _profiles = JsonConvert.DeserializeObject<List<UserProfile>>(json) ?? new();
        }
    }

    public async Task SaveProfilesAsync()
    {
        var json = JsonConvert.SerializeObject(_profiles);
        await _secureStorage.SaveCredentialAsync(ProfilesKey, json);
    }

    public void AddProfile(UserProfile profile)
    {
        if (!_profiles.Any(p => p.Nickname == profile.Nickname))
        {
            _profiles.Add(profile);
        }
    }

    public void SwitchProfile(string nickname)
    {
        _activeProfile = _profiles.FirstOrDefault(p => p.Nickname == nickname);
    }

    public UserProfile? GetActiveProfile() => _activeProfile;

    public IEnumerable<UserProfile> GetAllProfiles() => _profiles;
}
