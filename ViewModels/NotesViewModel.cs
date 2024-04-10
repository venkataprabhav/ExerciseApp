using CommunityToolkit.Maui.Core;

namespace _6002CEM_BohdanYermakov.ViewModels;

public partial class NotesViewModel : BaseViewModel
{
	[ObservableProperty]
	public ObservableCollection<IDrawingLine> lines = new();

	[RelayCommand]
	public void Clear()
	{
		Lines.Clear();
	}
}
