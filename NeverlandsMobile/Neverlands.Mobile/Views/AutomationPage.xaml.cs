using Neverlands.Mobile.ViewModels;

namespace Neverlands.Mobile.Views;

public partial class AutomationPage : ContentPage
{
	public AutomationPage(AutomationViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}
