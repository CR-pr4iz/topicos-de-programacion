using imc.MAUI.ViewModels;

namespace imc.MAUI.Wiews;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
        BindingContext = new MainViewModel();
	}
}