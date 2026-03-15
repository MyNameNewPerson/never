using Neverlands.Core.Interfaces;
using Neverlands.Mobile.ViewModels;
using Neverlands.Mobile.Views;

namespace Neverlands.Mobile;

public partial class App : Application
{
	public App(AppInitializer initializer)
	{
		System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
		InitializeComponent();

		MainPage = new ContentPage { Content = new ActivityIndicator { IsRunning = true, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center } };

		InitializeApp(initializer);
	}

	private async void InitializeApp(AppInitializer initializer)
	{
		await initializer.InitializeAsync();

		var shell = new AppShell();
		MainPage = shell;

		var hasAutoLogin = initializer.HasAutoLoginProfile();
		if (hasAutoLogin)
		{
			await Shell.Current.GoToAsync("///MainPage");
		}
		else
		{
			await Shell.Current.GoToAsync("//LoginPage");
		}
	}
}
