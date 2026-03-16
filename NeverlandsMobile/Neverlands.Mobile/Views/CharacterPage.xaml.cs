using Neverlands.Mobile.ViewModels;

namespace Neverlands.Mobile.Views;

public partial class CharacterPage : ContentPage
{
	public CharacterPage(CharacterViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}
