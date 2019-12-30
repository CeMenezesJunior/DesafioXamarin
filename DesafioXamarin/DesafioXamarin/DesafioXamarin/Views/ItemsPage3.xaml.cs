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
using Notes.Models;

namespace DesafioXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage3 : ContentPage
    {
        List<Record> items;
        Note estado = new Note();
        EstadoRepository repositorio = new EstadoRepository();

        public ItemsPage3()
        {
            InitializeComponent();
            AtualizaDados();

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
           

        }




        async void Botao_Clicado(object sender, EventArgs args)
        {
            repositorio.DeleteAllEstados();
            foreach(Record r in items)
            {
                estado.Nome = r.fields.Estado;
                estado.Capital = r.fields.Capital;
                estado.Sigla = r.fields.Sigla;
                estado.Regiao = r.fields.Regiao;
                estado.Date = r.createdTime;
                repositorio.InsertEstado(estado);
            }
            estadosBd.ItemsSource = repositorio.GetAllEstadosData();

        }
    }
}