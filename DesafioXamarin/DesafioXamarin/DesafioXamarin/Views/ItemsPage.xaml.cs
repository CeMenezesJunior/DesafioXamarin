using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DesafioXamarin.Models;
using DesafioXamarin.Views;
using DesafioXamarin.ViewModels;
using System.Net.Http;

namespace DesafioXamarin.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {

        public ItemsPage()
        {
            InitializeComponent();

            

            List<String> lista = new List<string>()
            {
                "Flamengo","Grêmio","Palmeiras","Athletico","Atlético","Botafogo","Fluminense","Vasco",s
            };

            lvCustomers.ItemsSource = lista;
        }


        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

       


    }
}