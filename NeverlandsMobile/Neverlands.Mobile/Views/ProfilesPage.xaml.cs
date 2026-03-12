using Neverlands.Mobile.ViewModels;

namespace Neverlands.Mobile.Views;

public partial class ProfilesPage : ContentPage
{
	public ProfilesPage(ProfilesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
