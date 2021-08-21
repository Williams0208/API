using FreshMvvm;
using Project1.PageModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var registerpage = FreshPageModelResolver.ResolvePageModel<RegisterPageModel>();
            var maincontainer = new FreshNavigationContainer(registerpage);
            MainPage = maincontainer;
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
