namespace _6002CEM_BohdanYermakov.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ExercisesDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
