using Microsoft.Extensions.Logging;
using Neverlands.Core.Interfaces;
using Neverlands.Infrastructure.Services;
using Neverlands.Automation.Services;
using Neverlands.Mobile.ViewModels;
using Neverlands.Mobile.Views;

namespace Neverlands.Mobile;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>().ConfigureFonts(fonts => {
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<INetworkService, NetworkService>();
        builder.Services.AddSingleton<IAntiCaptchaService, AntiCaptchaService>(sp => new AntiCaptchaService("YOUR_KEY_HERE"));
        builder.Services.AddSingleton<ISecureStorageService, SecureStorageService>();
        builder.Services.AddSingleton<IProfileManager, ProfileManager>();
        builder.Services.AddSingleton<ICombatService, CombatService>();
        builder.Services.AddSingleton<INavigationService, NavigationService>();
        builder.Services.AddSingleton<IResourceAutomationService, ResourceAutomationService>();
        builder.Services.AddSingleton<IBackgroundAutomationManager, BackgroundAutomationManager>();
        builder.Services.AddSingleton<IScriptManager, ScriptManager>();
        builder.Services.AddSingleton<AutomationEngine>();
        builder.Services.AddSingleton<AppInitializer>();

        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MapViewModel>();
        builder.Services.AddTransient<MapPage>();
        builder.Services.AddTransient<ProfilesViewModel>();
        builder.Services.AddTransient<ProfilesPage>();
        builder.Services.AddTransient<SettingsViewModel>();
        builder.Services.AddTransient<SettingsPage>();

        var app = builder.Build();
        ServiceProvider = app.Services;
        return app;
	}

    public static IServiceProvider? ServiceProvider { get; private set; }
}
