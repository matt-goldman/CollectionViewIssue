using CollectionViewSample.ViewModels;

namespace CollectionViewSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		var vm = new MainViewModel();

		BindingContext = vm;

		vm.Init();
	}

}

