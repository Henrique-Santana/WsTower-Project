using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato_App_G6.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Splash : ContentPage
    {
        public Splash()
        {
            InitializeComponent();

            navegacao();


        }

        private async void navegacao()
        {
            await Task.Delay(3000);

            App.Current.MainPage = new NavigationPage(new Login());
        }
    }
}