using _6002CEM_BohdanYermakov.Views.Dashboard;

namespace _6002CEM_BohdanYermakov;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        this.BindingContext = new AppShellViewModel();

        Routing.RegisterRoute(nameof(RecipesDetailPage), typeof(RecipesDetailPage));
		Routing.RegisterRoute(nameof(ExercisesDetailPage), typeof(ExercisesDetailPage));
		Routing.RegisterRoute(nameof(ClassesDetailPage), typeof(ClassesDetailPage));
        Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
        Routing.RegisterRoute(nameof(LocationsPage), typeof(LocationsPage));
        Routing.RegisterRoute(nameof(RecipesPage), typeof(RecipesPage));
    }
}
