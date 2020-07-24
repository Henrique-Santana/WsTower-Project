using Project_Grupo6.Models;
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
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        async void btnCadastro_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeEntry.Text) && (string.IsNullOrEmpty(emailEntry.Text) && (string.IsNullOrEmpty(senhaEntry.Text))))
            {

                DisplayAlert("Error",
                        "Todos os dados sâo obrigatorios.", "ok");
            }
            if (string.IsNullOrEmpty(nomeEntry.Text))
            {
                DisplayAlert("Error",
                        "Todos os dados sâo obrigatorios.", "ok");
            }
            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error", "Todos os dados sâo obrigatorios.", "ok");
            }

            if (string.IsNullOrEmpty(senhaEntry.Text))
            {
                DisplayAlert("Error", "Todos os dados sâo obrigatorios.", "ok");
            }



            if (!string.IsNullOrEmpty(nomeEntry.Text) && (!string.IsNullOrEmpty(emailEntry.Text) && (!string.IsNullOrEmpty(senhaEntry.Text))))
            {
                
                    await App.Database.SaveUsuarioAsync(new Usuario
                    {
                        nome = nomeEntry.Text,
                        email = emailEntry.Text,
                        senha = senhaEntry.Text
                    });

                    App.Current.MainPage = new NavigationPage(new Login());
                

            }
        }
    }
}