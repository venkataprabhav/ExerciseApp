namespace _6002CEM_BohdanYermakov.Views;

public partial class RecipesDetailPage : ContentPage
{
	public RecipesDetailPage(RecipesDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
