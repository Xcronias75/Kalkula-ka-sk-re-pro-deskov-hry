﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1
{
    public partial class App : Application
    {
        public static string FilePath;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        public App(string filePath)
        {
            InitializeComponent();

            MainPage = new MainPage();

            FilePath = filePath;
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
