using Neverlands.Infrastructure.Services;

namespace Neverlands.Mobile;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var initializer = Handler?.MauiContext?.Services
            .GetService<AppInitializer>();
        if (initializer != null)
        {
            await initializer.InitializeAsync();
            var route = initializer.HasAutoLoginProfile()
                ? "///main" : "//login";
            await Shell.Current.GoToAsync(route);
        }
    }
}
