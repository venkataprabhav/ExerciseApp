using _6002CEM_BohdanYermakov.Views.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _6002CEM_BohdanYermakov.ViewModels
{
    public class LoadPageViewModel
    {
        public LoadPageViewModel()
        {
            CheckUserLoginDetails();    // checks login details
        }

        private async void CheckUserLoginDetails()
        {
            string strUserDetails = Preferences.Get(nameof(App.UserDetails), "");

            if (string.IsNullOrWhiteSpace(strUserDetails))
            {
                // navigates user to login page
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
            else
            {   
                var userInfo = JsonConvert.DeserializeObject<User>(strUserDetails);
                App.UserDetails = userInfo;


                // navigates user to dashboard
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
        }
    }
}
