using FirstMauiApp.Models;
using FirstMauiApp.PageModels;

namespace FirstMauiApp.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}