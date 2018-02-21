using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Booking
{
	public partial class App : Application
	{
        public String consumer_key = "ocgM3uULblNsxFt1MzrA0GPbyVZbmlck3pH5n7ZC";
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new Booking.UpCommingPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
