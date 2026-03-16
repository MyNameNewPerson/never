using Neverlands.Mobile.ViewModels;

namespace Neverlands.Mobile.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}
