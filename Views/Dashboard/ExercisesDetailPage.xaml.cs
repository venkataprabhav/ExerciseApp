namespace _6002CEM_BohdanYermakov.Views;

public partial class ExercisesDetailPage : ContentPage
{
	public ExercisesDetailPage(ExercisesDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
