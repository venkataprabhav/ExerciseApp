namespace _6002CEM_BohdanYermakov.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ClassesDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
