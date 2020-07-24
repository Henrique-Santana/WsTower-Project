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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void btnCadastro_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Cadastro());
        }

        async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailUser.Text))
            {
                DisplayAlert("Aviso", "O email é obrigatório", "ok");
            }

            if (string.IsNullOrEmpty(senhaUser.Text))
            {
                DisplayAlert("Aviso", "A senha é obrigatório", "ok");
            }

            if (string.IsNullOrEmpty(emailUser.Text)
                && (string.IsNullOrEmpty(senhaUser.Text)))
            {
                DisplayAlert("Aviso", "Os campos estão vasios", "ok");
            }

            var usuarios = await App.Database.GetUsuarioAsync();

            var email = usuarios.Where(p => p.email == emailUser.Text).FirstOrDefault();
            var senha = usuarios.Where(p => p.senha == senhaUser.Text).FirstOrDefault();


            if ((email != null) && (senha != null))
            {
                App.Current.MainPage = new NavigationPage(new MainPage());
            }
        }
    }
}