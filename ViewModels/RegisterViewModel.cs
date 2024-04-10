namespace _6002CEM_BohdanYermakov.ViewModels;

public partial class RegisterViewModel : BaseViewModel
{
    [ObservableProperty]
    private string _email;

    [ObservableProperty]
    private string _password;

    #region Commands

    [RelayCommand]
    async void Register() // command to register new user
    {
        /*https://www.youtube.com/watch?v=GOFYE6sGWUY
          https://www.youtube.com/watch?v=z4_EQ2wM6No
          https://www.youtube.com/watch?v=0JlAkQI12Hk
          https://www.youtube.com/watch?v=dWnGoZY3XiE 
        The above videos were used as inspiration for the Register function*/

        if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password)) 
        {
            try
            {
                var registeredUsers = await App.Database.GetEmailAsync(Email); 
                if (registeredUsers.Any())
                {
                    await Shell.Current.DisplayAlert("Error", "User already Registered!", "OK"); 
                }
                else
                {
                    var user = new User
                    {
                        Email = Email,
                        Password = Password
                    };

                    await App.Database.AddUsersAsync(user);

                    var users = await App.Database.GetUsersAsync(); 



                    var user2 = users.FirstOrDefault(u => u.Email == Email && u.Password == Password); 

                    if (user2 != null)
                    {
                        await Shell.Current.GoToAsync($"///{nameof(MainPage)}");
                    }
                    else
                    {
                        await Shell.Current.DisplayAlert("Error", "error", "OK");
                    }
                }
            }
            catch (Exception ex) 
            {
                await Shell.Current.DisplayAlert("Error!", "Error", "OK");
            }
        }
    }

    #endregion
}
