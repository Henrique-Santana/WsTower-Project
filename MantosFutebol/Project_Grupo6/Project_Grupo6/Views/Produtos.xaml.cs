using Project_Grupo6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Grupo6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Produtos : ContentPage
    {
        public IList<Produto> produtos { get; private set; }
        public Produtos()
        {   
            InitializeComponent();

            produtos= new List<Produto>();
            produtos.Add(new Produto
            {
                ProdutName = "Camisa Manchester United",
                Preco = "R$199,99",
                Image = "camisa_manchester_united.jpg",
                Tipo = "Camiseta"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Camisa Liverpool",
                Preco = "R$199,99",
                Image = "camisa_liverpool.png",
                Tipo = "Camiseta"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Camisa Personalizada",
                Preco = "R$149,99",
                Image = "camiseta_Personalizada.png",
                Tipo = "Camiseta"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Camisa Bayer",
                Preco = "R$199,99",
                Image = "camisa_bayern_home.jpg",
                Tipo = "Camiseta"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Camisa Barcelona",
                Preco = "R$200,00",
                Image = "camisa_Barcelona.png",
                Tipo = "Camiseta"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Chuteira Adidas campo",
                Preco = "R$250,99",
                Image = "chuteira_Adidas.jpg",
                Tipo = "Chuteira"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Chuteira Adidas X campo",
                Preco = "R$500,00",
                Image = "chuteira_adidas_x.jpg",
                Tipo = "Chuteira"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Chuteira Nike ",
                Preco = "R$300,00",
                Image = "chuteira_nike.jpg",
                Tipo = "Chuteira"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Chuteira Nike Mercurial campo",
                Preco = "R$499,99",
                Image = "chuteira_campo_nike_mercurial.png",
                Tipo = "Chuteira"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Bone Manchester United",
                Preco = "R$150,00",
                Image = "bone_manchester_united.jpg",
                Tipo = "Bone"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Bone Chelsea",
                Preco = "R$150,00",
                Image = "bone_chelsea.jpg",
                Tipo = "Bone"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Bone Barcelona",
                Preco = "R$150,00",
                Image = "bone_Barcelona.jpg",
                Tipo = "Bone"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Bola Nike Futebol Verde ",
                Preco = "R$110,00",
                Image = "bola_futebol_Nike_verde.jpg",
                Tipo = "Bola"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Bola Copa Do Mundo Futebol ",
                Preco = "R$200,00",
                Image = "bola_futebol_copaDoMundo.jpg",
                Tipo = "Bola"
            });

            produtos.Add(new Produto
            {
                ProdutName = "Bola Nike Futebol ",
                Preco = "R$100,00",
                Image = "bola_futebol.jpg",
                Tipo = "Bola"
            });

            BindingContext = this;
            
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Produto selectedItem = e.SelectedItem as Produto;
            //App.Current.MainPage = new NavigationPage(new Principal());
            //Navigation.PushAsync(new PageBuy());
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new PageBuy
                {
                    BindingContext = e.SelectedItem as Produto
                });
            }
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Produto tappedItem = e.Item as Produto;
        }

        //public void SearchConteudoTextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var Keyword = SearchConteudo.Text;
        //    if (Keyword.Length >= 1)
        //    {
        //        var sugestao = produtos.Where(c => c.ToString().Contains(Keyword.ToLower()));
        //        ListaProduto.ItemsSource = sugestao;
        //        ListaProduto.IsVisible = true;
        //    }
        //    else
        //    {
        //        ListaProduto.IsVisible = false;
        //    }
        //}

        //public void ListaProdutoItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    if (e.Item as string == null)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        ListaProduto.ItemsSource = produtos.Where(c => c.Equals(e.Item as string));
        //        ListaProduto.IsVisible = true;
        //        SearchConteudo.Text = e.Item as string;
        //    }
        //}
    }

}