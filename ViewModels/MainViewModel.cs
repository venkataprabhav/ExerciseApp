namespace _6002CEM_BohdanYermakov.ViewModels;
using _6002CEM_BohdanYermakov.Views.Dashboard;
using _6002CEM_BohdanYermakov.Views;

public partial class MainViewModel : BaseViewModel
{
    /*https://www.youtube.com/watch?v=GOFYE6sGWUY
      https://www.youtube.com/watch?v=z4_EQ2wM6No
      https://www.youtube.com/watch?v=0JlAkQI12Hk
      https://www.youtube.com/watch?v=dWnGoZY3XiE 
    The above videos were used as inspiration for the Login function*/

    [ObservableProperty]
    private string _email;

    [ObservableProperty]
    private string _password;

    #region Commands

    [RelayCommand]
    async void Login()
    {
        if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))     
        {
            var users = await App.Database.GetUsersAsync();


            var user = users.FirstOrDefault(u => u.Email == Email && u.Password == Password);

            if (user != null)
            {
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", "Invalid email or password", "OK");
            }
        }
    }

    [RelayCommand]
    async void GoRegister()
    {
        await Shell.Current.GoToAsync($"///{nameof(RegisterPage)}");
    }

    #endregion
}
