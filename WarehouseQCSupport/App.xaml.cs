﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseQCSupport
{
    public partial class App : Application
    {
        public static string DbLocation = string.Empty;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
        public App(string dbLocation)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            DbLocation = dbLocation;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
