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
	public partial class NowPlayingPage : ContentPage
	{
		public NowPlayingPage ()
		{
			InitializeComponent ();
            GetImages();
            
		}

        private async void GetImages()
            {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("https://api.500px.com/v1/photos?consumer_key=ocgM3uULblNsxFt1MzrA0GPbyVZbmlck3pH5n7ZC");

            var images = JsonConvert.DeserializeObject<List<HomePageImages>>(response);

            if (images != null)
            {
                MovieListView.ItemsSource = images;
            };

        }
	}
}