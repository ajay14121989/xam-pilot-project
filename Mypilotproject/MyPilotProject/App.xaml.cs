﻿using MyPilotProject.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPilotProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainScreen();
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
