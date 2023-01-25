using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ABB_ACCMEX
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Presentacion.Login();
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
