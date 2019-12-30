using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DesafioXamarin.Services;
using DesafioXamarin.Views;

namespace DesafioXamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            
            MainPage = new MainPage();
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
