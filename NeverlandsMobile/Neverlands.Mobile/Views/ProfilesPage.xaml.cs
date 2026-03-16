using Neverlands.Mobile.ViewModels;

namespace Neverlands.Mobile.Views;

public partial class ProfilesPage : ContentPage
{
	public ProfilesPage(ProfilesViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        (BindingContext as ProfilesViewModel)?.LoadProfiles();
    }
}
