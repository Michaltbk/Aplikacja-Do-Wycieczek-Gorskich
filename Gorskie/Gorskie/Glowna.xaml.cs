﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gorskie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Glowna : TabbedPage
    {
        public Glowna()
        {
            InitializeComponent();

            CurrentPage = Children.FirstOrDefault(page=> page.Title == "Mapa");
        }
    }
}