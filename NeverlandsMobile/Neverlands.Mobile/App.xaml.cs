using Neverlands.Core.Interfaces;
using Neverlands.Mobile.ViewModels;
using Neverlands.Mobile.Views;

namespace Neverlands.Mobile;

public partial class App : Application
{
	public App()
	{
		System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
		InitializeComponent();

		MainPage = new AppShell();
	}
}
