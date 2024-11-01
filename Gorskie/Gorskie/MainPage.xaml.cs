﻿using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace Gorskie
{
    public partial class MainPage : ContentPage
    {
        FirebaseClient firebaseClient = new Firebase.Database.FirebaseClient("https://gorskie-610c5-default-rtdb.europe-west1.firebasedatabase.app/");
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                messageLabel.Text = "Brak połączenia!";
                return;
            }

            string name = usernameEntry.Text;
            string password = passwordEntry.Text;

            var existingRecords = await firebaseClient
                .Child("Records")
                .OnceAsync<MyDatabaseRecord>();

            foreach (var variableName in existingRecords)
            {

                if (variableName.Object.MyName == name && variableName.Object.MyPassword == password)
                {
                    await Navigation.PushAsync(new Glowna());
                    return;
                }
            }
            messageLabel.Text = "Złe hasło lub brak użytkownika";
        }


        private async void Button_Register(object sender, EventArgs e)
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                messageLabel.Text = "Brak połączenia!";
                return;
            }

            messageLabel.Text = "Zarejestrowano";

            var record = new MyDatabaseRecord
            {
                MyName = usernameEntry.Text,
                MyPassword = passwordEntry.Text
            };

            await firebaseClient.Child("Records").PostAsync(record);

        }
    }

}