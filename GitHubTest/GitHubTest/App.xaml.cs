using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1;

namespace GitHubTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Car_add_company();
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
