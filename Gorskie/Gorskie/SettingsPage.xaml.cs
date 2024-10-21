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
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();

        }

        private async void friendsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FriendsPage());
        }

        private async void settingsButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Ustawienia", "Jesteś już w ustawieniach!", "OK");
        }

        private async void mapButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }
    }
}