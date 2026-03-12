using Neverlands.Core.Interfaces;
using Neverlands.Mobile.ViewModels;
using Neverlands.Mobile.Views;

namespace Neverlands.Mobile;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
