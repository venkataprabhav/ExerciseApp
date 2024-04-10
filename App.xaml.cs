namespace _6002CEM_BohdanYermakov;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    public static User UserDetails;

    public static Recipe recipe;

    private static Database database;
    public static Database Database
    {
        get
        {
            if (database == null)
            {
                database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "allin.db3"));
            }

            return database;
        }
    }
}
