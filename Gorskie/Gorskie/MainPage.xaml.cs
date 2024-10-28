using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Gorskie
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string imie = usernameEntry.Text;
            string haslo = passwordEntry.Text;

            if (imie == "admin" && haslo == "123")
            {
                await Navigation.PushAsync(new Glowna());
            }
            else
            {
                messageLabel.Text = "Podano zle dane";
            }


        }


    }
}
