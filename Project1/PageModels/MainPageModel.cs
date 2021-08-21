using FreshMvvm;
using Project1.Models;
using Project1.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project1.PageModels
{
    public class MainPageModel: FreshBasePageModel
    {
        private string _Password;
        public string Password
        {
            set
            {
                _Password = value;
                RaisePropertyChanged();
            }
            get
            {
                return _Password;
            }
        }
        private string _userName;
        public string UserName
        {
            set
            {
                _userName = value;
                RaisePropertyChanged();
            }
            get
            {
                return _userName;
            }
        }
        public Command RegisterCommand => new Command(async () => await Login());
        

        private async Task Login()
        {
            var response = await ApiService.Login(UserName, Password);
            if (response)
            {
                await CoreMethods.DisplayAlert("", "Login exitoso Bienvenido", "Ok");
                await CoreMethods.PushPageModel<HomePageModel>(UserName);
            }
            else
            {
                await CoreMethods.DisplayAlert("", "Error, credenciales incorrectas", "Ok");
            }
        }
    }
}
