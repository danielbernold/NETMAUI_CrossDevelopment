namespace NETMAUI_App.Views;

public partial class PostPage : ContentPage
{
	public PostPage()
	{
		InitializeComponent();

		Loaded += async (_, _) =>
		{
			var vm = BindingContext as ViewModels.PostViewModel;
			await vm.LoadPostsAsync();
		};
	}
}