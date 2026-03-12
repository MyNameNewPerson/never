using Neverlands.Mobile.ViewModels;

namespace Neverlands.Mobile.Views;

public partial class MapPage : ContentPage
{
	public MapPage(MapViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
