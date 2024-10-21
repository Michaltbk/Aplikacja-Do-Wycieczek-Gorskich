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
	public partial class MapPage : ContentPage
	{
		public MapPage ()
		{
			InitializeComponent ();
		}

        private async void mapButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mapa", "Jesteś już na mapie!", "OK");
        }

        private async void settingsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }

        private async void friendsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FriendsPage());
        }
    }
}