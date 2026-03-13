using Neverlands.Automation.Services;
using Neverlands.Core.Models;
using Neverlands.Core.Models.Combat;
using Neverlands.Core.Interfaces;
using Neverlands.Infrastructure.Services;
using Xunit;

namespace Neverlands.Tests;

public class AutomationTests
{
    [Fact]
    public void CombatService_DetectsCombat_FromHtml()
    {
        var service = new CombatService();
        var profile = new UserProfile { Nickname = "Hero" };
        var combatHtml = "<html><body>var fight_ty = [0, 0, 100, 1, 0, 0]; var param_ow = [0, 100, 100, 100, 100]; var fight_pm = [\"bot1\", 0, 0, 0, \"vcode\", \"0\", \"0\", \"0\", \"0\", \"0\", \"0\"]; </body></html>";
        var decision = service.AnalyzeFight(combatHtml, profile);
        Assert.True(decision.IsInCombat);
        Assert.True(decision.IsMyTurn);
    }

    [Fact]
    public void CombatService_HandlesCooldowns()
    {
        var service = new CombatService();
        var profile = new UserProfile { Nickname = "Hero" };
        // Heal spell code 388
        var combatHtml = "<html><body>var fight_ty = [0, 0, 100, 1, 0, 0]; var param_ow = [0, 20, 100, 100, 100]; var fight_pm = [\"bot1\", 0, 0, 0, \"vcode\", \"0\", \"0\", \"0\", \"0\", \"0\", \"0\"]; var magic_in = [388]; </body></html>";

        var decision1 = service.AnalyzeFight(combatHtml, profile);
        Assert.Contains("388@", decision1.PostData);

        var decision2 = service.AnalyzeFight(combatHtml, profile);
        Assert.DoesNotContain("388@", decision2.PostData); // Should be on cooldown
    }

    [Fact]
    public void NavigationService_ValidatesPath()
    {
        var service = new NavigationService(null!);
        var abCells = @"<cells><cell regnum=""18-226"" label=""Start"" cost=""30""/><cell regnum=""18-227"" label=""End"" cost=""30""/></cells>";
        var mapXml = @"<map><cell cellNumber=""18-226"" cost=""21""/><cell cellNumber=""18-227"" cost=""21""/></map>";
        service.LoadMapData(abCells, mapXml);
        var result = service.IsPathExists("18-226", "18-227");
        Assert.True(result);
    }

    [Fact]
    public void NavigationService_SupportsMines()
    {
        var service = new NavigationService(null!);
        var minesXml = @"<mines><mine mineid=""1"" level=""1""><cell x=""0"" y=""0"" img=""b_2""/><cell x=""1"" y=""0"" img=""rb_4""/></mine></mines>";
        service.LoadMinesData(minesXml);
        Assert.True(service.IsPathExists("mine-1-1-0-0", "mine-1-1-1-0"));
    }

    [Fact]
    public void NavigationService_SupportsTeleports()
    {
        var service = new NavigationService(null!);
        var abCells = @"<cells><cell regnum=""1-001"" label=""A""/><cell regnum=""2-001"" label=""B""/></cells>";
        var teleportsXml = @"<teleports><teleport regnum=""1-001"" name=""T1""/><teleport regnum=""2-001"" name=""T2""/></teleports>";
        service.LoadMapData(abCells, "<map></map>");
        service.LoadTeleportsData(teleportsXml);

        Assert.True(service.IsPathExists("1-001", "2-001"));
    }

    [Fact]
    public async Task ProfileManager_PersistsProfiles()
    {
        var storage = new SecureStorageService();
        var manager = new ProfileManager(storage);
        var profile = new UserProfile { Nickname = "TestBot", Password = "123" };

        manager.AddProfile(profile);
        await manager.SaveProfilesAsync();

        var manager2 = new ProfileManager(storage);
        await manager2.LoadProfilesAsync();

        Assert.Contains(manager2.GetAllProfiles(), p => p.Nickname == "TestBot");
    }

    [Fact]
    public async Task ResourceAutomation_TriggersInternalSteps()
    {
        var net = new MockNetworkService();
        var captcha = new MockAntiCaptchaService();
        var background = new BackgroundAutomationManager();
        var resource = new ResourceAutomationService(net, captcha, background);
        var script = new ScriptManager(null!, null!, resource, net);

        await resource.StartWoodcuttingAsync();
        var task = background.GetTasks().First();

        await script.ExecuteActionAsync(task.Action, task.Parameter, new UserProfile());

        Assert.True(net.GetCalled);
    }

    [Fact]
    public async Task AutomationEngine_ProcessesGameState()
    {
        var net = new MockNetworkService();
        var combat = new CombatService();
        var profileManager = new ProfileManager(new SecureStorageService());
        var engine = new AutomationEngine(null!, null!, net, combat, profileManager);

        var combatHtml = "<html><body>var fight_ty = [0, 0, 100, 1, 0, 0]; var param_ow = [0, 100, 100, 100, 100]; var fight_pm = [\"bot1\", 0, 0, 0, \"vcode\", \"0\", \"0\", \"0\", \"0\", \"0\", \"0\"]; </body></html>";
        await engine.ProcessGameStateAsync(combatHtml, new UserProfile());

        Assert.True(net.PostCalled);
    }

    private class MockNetworkService : INetworkService
    {
        public bool GetCalled { get; private set; }
        public bool PostCalled { get; private set; }
        public Task<string?> GetAsync(string url) { GetCalled = true; return Task.FromResult<string?>(""); }
        public Task<byte[]?> GetAsync(string url, bool returnBytes) { GetCalled = true; return Task.FromResult<byte[]?>(null); }
        public Task<string?> PostAsync(string url, string content) { PostCalled = true; return Task.FromResult<string?>(""); }
    }

    private class MockAntiCaptchaService : IAntiCaptchaService
    {
        public Task<string?> SolveCaptchaAsync(byte[] imageBytes) => Task.FromResult<string?>("12345");
    }
}
