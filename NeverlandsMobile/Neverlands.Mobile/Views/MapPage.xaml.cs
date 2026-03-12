namespace Neverlands.Mobile.Views;

public partial class MapPage : ContentPage
{
	public MapPage(ViewModels.MapViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
	}
}
