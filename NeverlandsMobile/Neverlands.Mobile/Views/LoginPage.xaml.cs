using Neverlands.Mobile.ViewModels;

namespace Neverlands.Mobile.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}
