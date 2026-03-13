using Neverlands.Infrastructure.Services;

namespace Neverlands.Mobile;

public partial class App : Application
{
	public App(AppInitializer initializer)
	{
		InitializeComponent();

		MainPage = new AppShell();

		Task.Run(async () => await initializer.InitializeAsync());
	}
}
