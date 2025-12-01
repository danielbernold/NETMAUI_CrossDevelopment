namespace NETMAUI_App.Views;
using NETMAUI_App.ViewModels;

public partial class CardPage : ContentPage
{
	public CardPage()
	{
		InitializeComponent();
		BindingContext = new CardViewModel();
	}
}