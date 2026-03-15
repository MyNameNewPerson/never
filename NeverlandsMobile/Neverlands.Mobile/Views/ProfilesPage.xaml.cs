namespace Neverlands.Mobile.Views;

public partial class ProfilesPage : ContentPage
{
	public ProfilesPage(ViewModels.ProfilesViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
	}
}
