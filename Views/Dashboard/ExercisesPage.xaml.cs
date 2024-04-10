namespace _6002CEM_BohdanYermakov.Views;

public partial class ExercisesPage : ContentPage
{
	ExercisesViewModel ViewModel;

	public ExercisesPage(ExercisesViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
	}

	
}
