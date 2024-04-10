namespace _6002CEM_BohdanYermakov.Views;

public partial class ClassesDetailPage : ContentPage
{
	public ClassesDetailPage(ClassesDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
