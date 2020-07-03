using Campeonato_App_G6.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato_App_G6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Splash();
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
