namespace Neverlands.Mobile;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("MapPage", typeof(Views.MapPage));
        Routing.RegisterRoute("ProfilesPage", typeof(Views.ProfilesPage));
        Routing.RegisterRoute("SettingsPage", typeof(Views.SettingsPage));
	}
}
