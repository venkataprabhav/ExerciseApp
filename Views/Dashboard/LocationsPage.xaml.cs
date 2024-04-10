

namespace _6002CEM_BohdanYermakov.Views
{
    public partial class LocationsPage : ContentPage
    {
        public LocationsPage(LocationsViewModel viewModel)
        {
            InitializeComponent();

            ALLIN.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
            {
                Label = "ALL.IN - Kharkiv",
                Location = new Location(50.02442082572848, 36.21120179527156)
            });

            ALLIN.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
            {
                Label = "ALL.IN - Solihull Gym",
                Location = new Location(52.414441140608325, -1.7810768162167432)
            });

            ALLIN.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
            {
                Label = "ALL.IN - Birmingham Gym",
                Location = new Location(52.51846152121488, -1.9286729538447227)
            });

            ALLIN.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
            {
                Label = "ALL.IN - Coventry Gym",
                Location = new Location(52.408950255464, -1.5210675772448796)
            });

            ALLIN.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
            {
                Label = "ALL.IN - Tamworth",
                Location = new Location(52.62777600529532, -1.6829213834577907)
            });

            ALLIN.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
            {
                Label = "ALL.IN - Stratford-Upon_Avon",
                Location = new Location(52.19565263840912, -1.7105818633154009)
            });

            ALLIN.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
            {
                Label = "ALL.IN - Redditch",
                Location = new Location(52.30394109284911, -1.9501351803059426)
            });

            BindingContext = viewModel;
#if WINDOWS
            // Note that the map control is not supported on Windows.
            // For more details, see https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/map?view=net-maui-7.0
            // For a possible workaround, see https://github.com/CommunityToolkit/Maui/issues/605
            Content = new Label() { Text = "Windows does not have a map control. 😢" };
#endif
        }
    }
}