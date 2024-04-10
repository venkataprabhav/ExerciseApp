using CommunityToolkit.Maui.Views;

namespace _6002CEM_BohdanYermakov.Views;

public partial class NotesPage : ContentPage
{
	public NotesPage(NotesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	private async void SaveClicked(object sender, EventArgs e)
	{
		var drawingLines = (BindingContext as NotesViewModel).Lines.ToList();
		var points = drawingLines.SelectMany(x => x.Points).ToList();

		var stream = await DrawingView.GetImageStream(
			drawingLines,
			new Size(points.Max(x => x.X) - points.Min(x => x.X), points.Max(x => x.Y) - points.Min(x => x.Y)),
			Colors.Gray);

		GeneratedImage.Source = ImageSource.FromStream(() => stream);
	}
}
