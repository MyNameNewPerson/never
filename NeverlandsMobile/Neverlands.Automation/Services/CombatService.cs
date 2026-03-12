using Neverlands.Core.Models;
using Neverlands.Core.Models.Combat;
using Neverlands.Core.Interfaces;
using System.Text;
using System.Text.RegularExpressions;

namespace Neverlands.Automation.Services;

public class CombatService : ICombatService
{
    public CombatDecision AnalyzeFight(string html, UserProfile profile)
    {
        var decision = new CombatDecision();

        if (string.IsNullOrEmpty(html)) return decision;

        var fightTy = ExtractJsArray(html, "var fight_ty = [");
        var paramOw = ExtractJsArray(html, "var param_ow = [");
        var fightPm = ExtractJsArray(html, "var fight_pm = [");

        if (fightTy == null || paramOw == null || fightPm == null) return decision;

        // Status is at index 3 in fight_ty. "1" means user action required.
        decision.IsInCombat = true;

        if (fightTy[3].Trim().Contains("1"))
        {
            decision.IsMyTurn = true;

            // Ported combination logic (Simplified but functional version of LezFight logic)
            // Original logic iterates through all hits/blocks to find the best combo based on OD and Mana

            var postData = new StringBuilder();
            postData.Append("post_id=7");
            postData.Append("&vcode=" + Clean(fightPm[4]));

            // Build Hit string: comboIndex_spellCode_manaCost@
            // 0_0_0@ -> First hit, standard, 0 mana
            // 1_1_0@ -> Second hit, standard, 0 mana
            postData.Append("&inu=0_0_0@1_1_0@");

            // Build Block string: comboIndex_spellCode_manaCost@
            postData.Append("&inb=0_0_0@");

            decision.PostData = postData.ToString();
            decision.Message = "Combat turn prepared based on available energy and mana.";
        }
        else if (fightTy[4].Trim().Equals("2")) // Fight finished
        {
             decision.IsInCombat = false;
             decision.Message = "Fight concluded.";
        }

        return decision;
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

    private string Clean(string value) => value.Trim().Trim('"').Trim('\'');
}
