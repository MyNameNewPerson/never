using Neverlands.Automation.Services;
using Neverlands.Core.Models;
using Neverlands.Core.Interfaces;
using Xunit;
namespace Neverlands.Tests;
public class AutomationTests {
    [Fact] public void CombatService_DetectsCombat_FromHtml() {
        var service = new CombatService();
        var profile = new UserProfile { Nickname = "Hero" };
        var combatHtml = "<html><body>var fight_ty = [0, 0, 100, 1, 0, 0]; var param_ow = [0, 100, 100, 100, 100]; var fight_pm = [0, 0, 0, 0, \"vcode\"]; </body></html>";
        var decision = service.AnalyzeFight(combatHtml, profile);
        Assert.True(decision.IsInCombat); Assert.True(decision.IsMyTurn);
    }
    [Fact] public void NavigationService_ValidatesPath() {
        var service = new NavigationService(null!);
        var abCells = @"<cells><cell regnum=""18-226"" label=""Start"" cost=""30""/><cell regnum=""18-227"" label=""End"" cost=""30""/></cells>";
        var mapXml = @"<map><cell cellNumber=""18-226"" cost=""21""/><cell cellNumber=""18-227"" cost=""21""/></map>";
        service.LoadMapData(abCells, mapXml);
        var result = service.IsPathExists("18-226", "18-227");
        Assert.True(result);
    }
}
