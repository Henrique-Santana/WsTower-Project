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
    public partial class PageBuy : ContentPage
    {
        public PageBuy()
        {
            InitializeComponent();
        }

        //async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("Alert", "This is an alert.", "OK");
        //}

        async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Comprar?", "Tem certeza? Não vai se endividar em, depois não diga que não avisei", "Yes", "No");
            Console.WriteLine("Save data: " + response);
        }
    }
}