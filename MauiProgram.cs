using _6002CEM_BohdanYermakov.Views.Dashboard;

namespace _6002CEM_BohdanYermakov;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiMaps()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<RegisterViewModel>();
		builder.Services.AddSingleton<RegisterPage>();

        builder.Services.AddSingleton<LoadPage>();
        builder.Services.AddSingleton<LoadPageViewModel>();

        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<DashboardPageViewModel>();

        builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ClassesDetailViewModel>();
		builder.Services.AddTransient<ClassesDetailPage>();

		builder.Services.AddSingleton<ClassesViewModel>();

		builder.Services.AddSingleton<ClassesPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ExercisesDetailViewModel>();
		builder.Services.AddTransient<ExercisesDetailPage>();

		builder.Services.AddSingleton<ExercisesViewModel>();

		builder.Services.AddSingleton<ExercisesPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<RecipesDetailViewModel>();
		builder.Services.AddTransient<RecipesDetailPage>();

		builder.Services.AddSingleton<RecipesViewModel>();
		builder.Services.AddSingleton<RecipesPage>();

		builder.Services.AddSingleton<NotesViewModel>();

		builder.Services.AddSingleton<NotesPage>();

		
		builder.Services.AddSingleton<LocationsViewModel>();
		builder.Services.AddSingleton<LocationsPage>();

		return builder.Build();
	}
}
