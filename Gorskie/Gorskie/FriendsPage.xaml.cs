using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gorskie
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FriendsPage : ContentPage
	{
		public FriendsPage ()
		{
			InitializeComponent ();
		}

        private async void friendsButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Ustawienia", "Jesteś już w znajomych!", "OK");
        }

        private async void settingsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }

        private async void mapButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }

    }
}