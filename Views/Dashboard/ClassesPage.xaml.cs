namespace _6002CEM_BohdanYermakov.Views;
using _6002CEM_BohdanYermakov.ViewModels;

public partial class ClassesPage : ContentPage
{
	ClassesViewModel ViewModel;


    public ClassesPage(ClassesViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
	}

	

}
