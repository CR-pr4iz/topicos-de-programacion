using Calculadora_Propinas.ViewModels;

namespace Calculadora_Propinas.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}