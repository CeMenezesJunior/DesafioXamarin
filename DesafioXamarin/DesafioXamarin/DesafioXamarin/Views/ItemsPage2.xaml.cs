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
using Newtonsoft.Json;
using DesafioXamarin.Deserialize;
using DesafioXamarin.Services;
using System.Collections.ObjectModel;
using static System.Net.Mime.MediaTypeNames;

namespace DesafioXamarin.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage2 : ContentPage
    {
        List<Record> items;

        public ItemsPage2()
        {
            InitializeComponent();
            AtualizaDados();

        }


        async void AddItem_Clicked(object sender, EventArgs e)
        {

        }

        private async Task<List<Record>> LerAPI()
        {
            HttpClient cliente = new HttpClient();
            var resposta = await cliente.GetStringAsync("https://api.airtable.com/v0/app0RCW0xYP8RT3U9/Estados?api_key=keyhS9s7U3bGKSuml");
            var estados = JsonConvert.DeserializeObject<Estados>(resposta);
            var teste = estados.records;
            return teste;
        }

        private async void AtualizaDados()
        {
            items = await LerAPI();
            estadosLista.ItemsSource = Listar();

        }

        

        public IEnumerable<Agrupar<string, Record>> Listar(string filtro = "")
        {

            IEnumerable<Record> estadosFiltrados = this.items;
            if (!string.IsNullOrEmpty(filtro))
            {
                estadosFiltrados = items.Where(l => (l.fields.Estado.ToLower().Contains(filtro.ToLower())) || (l.fields.Capital.ToLower().Contains(filtro.ToLower())));
            }
            return from estados in estadosFiltrados
                   orderby estados.fields.Estado
                   group estados by estados.fields.Regiao into grupos
                   select new Agrupar<string, Record>(grupos.Key, grupos);



        }

    }
}