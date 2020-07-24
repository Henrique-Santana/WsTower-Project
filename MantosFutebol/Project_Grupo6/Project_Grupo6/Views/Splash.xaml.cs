using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Grupo6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Splash : ContentPage
    {
        public Splash()
        {
            InitializeComponent();
            animacoes();
        }

        private async Task animacoes()
        {
            await Task.Delay(2000);

            await Task.WhenAll(
                   frase.FadeTo(0, 5000),
                   logomantos.RotateTo(360, 5000),
                   logomantos.FadeTo(0, 5000));

            App.Current.MainPage = new NavigationPage(new Login());
        }
    }
}