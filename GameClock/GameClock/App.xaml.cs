using GameClock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GameClock
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GameClock.Views.GameView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        private Game GetDefaultGame()
        {
            return new Game()
            {
                Name = "5 min"
            };
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
