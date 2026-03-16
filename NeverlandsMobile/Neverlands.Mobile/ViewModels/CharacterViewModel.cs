using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;

namespace Neverlands.Mobile.ViewModels;

public partial class CharacterViewModel : ObservableObject
{
    private readonly IProfileManager _profileManager;

    [ObservableProperty] private string _name = "Unknown";
    [ObservableProperty] private int _level = 1;
    [ObservableProperty] private int _currentHp = 100;
    [ObservableProperty] private int _maxHp = 100;
    [ObservableProperty] private int _currentMp = 50;
    [ObservableProperty] private int _maxMp = 50;
    [ObservableProperty] private long _currentExp = 0;
    [ObservableProperty] private long _maxExp = 1000;
    [ObservableProperty] private int _attack = 10;
    [ObservableProperty] private int _defense = 10;
    [ObservableProperty] private int _speed = 10;
    [ObservableProperty] private int _luck = 10;
    [ObservableProperty] private int _gold = 0;

    public double HpPercent => MaxHp > 0 ? (double)CurrentHp / MaxHp : 0;
    public double MpPercent => MaxMp > 0 ? (double)CurrentMp / MaxMp : 0;
    public double ExpPercent => MaxExp > 0 ? (double)CurrentExp / MaxExp : 0;

    public string HpStatus => $"{CurrentHp} / {MaxHp}";
    public string MpStatus => $"{CurrentMp} / {MaxMp}";
    public string ExpStatus => $"{CurrentExp} / {MaxExp}";

    public CharacterViewModel(IProfileManager profileManager)
    {
        _profileManager = profileManager;
        LoadCharacterData();
    }

    private void LoadCharacterData()
    {
        var profile = _profileManager.GetActiveProfile();
        if (profile != null)
        {
            Name = profile.Nickname;
        }
    }

    [RelayCommand]
    private async Task Refresh()
    {
        // Actual data fetch logic would be implemented here
        await Task.Delay(500);
        LoadCharacterData();
    }
}
