using Neverlands.Infrastructure.Services;

namespace Neverlands.Mobile;

public partial class App : Application
{
    public App(AppInitializer initializer)
    {
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        InitializeComponent();
        MainPage = new AppShell();
    }
}
