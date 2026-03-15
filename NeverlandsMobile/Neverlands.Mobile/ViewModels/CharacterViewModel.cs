using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Neverlands.Core.Interfaces;
using System.Collections.ObjectModel;

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
    [ObservableProperty] private int _attack = 10;
    [ObservableProperty] private int _defense = 10;
    [ObservableProperty] private int _gold = 0;

    public string HpStatus => $"{CurrentHp}/{MaxHp}";
    public string MpStatus => $"{CurrentMp}/{MaxMp}";

    public ObservableCollection<EquipmentSlot> Equipment { get; } = new();

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

        // Mock data for initial implementation
        Equipment.Clear();
        Equipment.Add(new EquipmentSlot { SlotName = "Голова", ItemName = "Кожаный шлем" });
        Equipment.Add(new EquipmentSlot { SlotName = "Тело", ItemName = "Кожаная броня" });
        Equipment.Add(new EquipmentSlot { SlotName = "Оружие", ItemName = "Меч новичка" });
    }

    [RelayCommand]
    private async Task RefreshAsync()
    {
        await Task.Delay(500);
        LoadCharacterData();
    }
}

public class EquipmentSlot
{
    public string SlotName { get; set; } = string.Empty;
    public string ItemName { get; set; } = string.Empty;
}
