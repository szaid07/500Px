using Booking.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Booking
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UpCommingPage : ContentPage
	{
        ActivityIndicator indicator = new ActivityIndicator();
        public UpCommingPage ()
		{
			InitializeComponent ();
		}

        private void btnSignUp_Clicked(object sender, EventArgs e)
        {
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            LoginLoader.IsVisible = true;
            getUserLogin();
        }

        private async void getUserLogin()
        {
            
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("https://api.500px.com/v1/users/show?consumer_key=ocgM3uULblNsxFt1MzrA0GPbyVZbmlck3pH5n7ZC&username=" + txtLogin.Text);
            var user = JsonConvert.DeserializeObject<User>(response);

            LoginLoader.IsVisible = false;
            if (user != null)
                await Navigation.PushAsync(new NowPlayingPage());
        }

    }
}