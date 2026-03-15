using Neverlands.Core.Models;
using Neverlands.Core.Models.Combat;
using Neverlands.Core.Interfaces;
using Neverlands.Core;
using System.Text;
using System.Text.RegularExpressions;

namespace Neverlands.Automation.Services;

public class CombatService : ICombatService
{
    private readonly Dictionary<int, int> _cooldowns = new();

    public CombatDecision AnalyzeFight(string html, UserProfile profile)
    {
        var decision = new CombatDecision();
        if (string.IsNullOrEmpty(html)) return decision;

        var fightTy = ExtractJsArray(html, "var fight_ty = [");
        var paramOw = ExtractJsArray(html, "var param_ow = [");
        var fightPm = ExtractJsArray(html, "var fight_pm = [");
        var magicIn = ExtractJsArray(html, "var magic_in = [");
        var alchemy = ExtractJsArray(html, "var alchemy = ["); // index in alchemy matches magic_in

        if (fightTy == null || paramOw == null || fightPm == null) return decision;

        decision.IsInCombat = true;
        UpdateCooldowns();

        if (fightTy[3].Trim().Equals("1"))
        {
            decision.IsMyTurn = true;

            double.TryParse(Clean(paramOw[1]), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var curHp);
            double.TryParse(Clean(paramOw[2]), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var maxHp);
            double.TryParse(Clean(paramOw[3]), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var curMa);
            double.TryParse(Clean(paramOw[4]), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var maxMa);

            int currentHpPct = (maxHp > 0) ? (int)(curHp * 100 / maxHp) : 0;
            int currentMaPct = (maxMa > 0) ? (int)(curMa * 100 / maxMa) : 0;

            var postData = new StringBuilder();
            postData.Append("post_id=7");
            postData.Append("&vcode=" + Clean(fightPm[4]));
            postData.Append("&enemy=" + Clean(fightPm[5]));
            postData.Append("&group=" + Clean(fightPm[6]));
            postData.Append("&inf_bot=" + Clean(fightPm[7]));
            postData.Append("&inf_zb=" + Clean(fightPm[10]));

            int.TryParse(Clean(fightPm[5]), out var enemyLevel);
            postData.Append("&lev_bot=" + enemyLevel);
            postData.Append("&ftr=" + Clean(fightTy[2]));

            string enemyName = Clean(fightPm[0]);
            bool isRareBot = IsRareBot(enemyName);
            bool isHuman = !enemyName.StartsWith("bot", StringComparison.OrdinalIgnoreCase);

            var hitsStr = new StringBuilder();
            // Complex hit selection: if Ma > 50% and not human, use magic hit (code 2)
            var hitCode = (currentMaPct > 50 && !isHuman) ? "2" : "0";
            hitsStr.Append("0_" + hitCode + "_0@");

            var blocksStr = new StringBuilder();
            // Complex block selection: if Hp < 40%, use more defensive block (code 6)
            var blockCode = (currentHpPct < 40) ? "6" : "4";
            blocksStr.Append("0_" + blockCode + "_0@");

            var magicStr = new StringBuilder();

            // HP Restoration with Cooldown Check
            if (currentHpPct < 50 && magicIn != null)
            {
                foreach (var s in magicIn) {
                    if (int.TryParse(Clean(s), out var code) && CombatSpellConstants.RestoreHp.Contains(code)) {
                        if (!_cooldowns.ContainsKey(code)) {
                            magicStr.Append(code + "@");
                            _cooldowns[code] = 5; // Simple cooldown simulation
                            break;
                        }
                    }
                }
            }

            // Mana Restoration with Cooldown Check
            if (currentMaPct < 30 && magicStr.Length == 0 && magicIn != null)
            {
                 foreach (var s in magicIn) {
                    if (int.TryParse(Clean(s), out var code) && CombatSpellConstants.RestoreMa.Contains(code)) {
                        if (!_cooldowns.ContainsKey(code)) {
                            magicStr.Append(code + "@");
                            _cooldowns[code] = 3;
                            break;
                        }
                    }
                }
            }

            postData.Append("&inu=" + hitsStr);
            postData.Append("&inb=" + blocksStr);
            postData.Append("&ina=" + magicStr);

            decision.PostData = postData.ToString();
            // Simple Buff Tracking (e.g. fromAlchemy)
            if (alchemy != null)
            {
                foreach (var a in alchemy)
                {
                    decision.ActiveBuffs.Add(Clean(a));
                }
            }

            decision.Message = $"Turn generated. HP: {currentHpPct}%, Ma: {currentMaPct}%";
            decision.Cooldowns = new Dictionary<int, int>(_cooldowns);
        }
        else if (fightTy[4].Trim().Equals("2"))
        {
            decision.IsInCombat = false;
            decision.Message = "Combat ended.";
            _cooldowns.Clear();
        }

        return decision;
    }

    private void UpdateCooldowns()
    {
        var keys = _cooldowns.Keys.ToList();
        foreach (var key in keys)
        {
            if (_cooldowns[key] > 0) _cooldowns[key]--;
            if (_cooldowns[key] <= 0) _cooldowns.Remove(key);
        }
    }

    private string[]? ExtractJsArray(string html, string prefix)
    {
        int start = html.IndexOf(prefix);
        if (start == -1) return null;
        int end = html.IndexOf("]", start);
        if (end == -1) return null;
        string content = html.Substring(start + prefix.Length, end - (start + prefix.Length));
        return content.Split(',');
    }

    private bool IsRareBot(string name)
    {
        string[] rareBots = { "Королева Змей", "Хранитель Леса", "Громлех Синезубый", "Выползень", "Озлобленный Дух", "Кхалганский Налетчик", "Подручный Атамана", "Прислужник Локара", "Друид-отступник" };
        return rareBots.Any(r => name.Equals(r, StringComparison.OrdinalIgnoreCase));
    }

    private string Clean(string value) => value.Trim().Trim('"').Trim('\'');
}
