using FreshMvvm;
using Project1.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project1.PageModels
{
    public class RegisterPageModel: FreshBasePageModel
    {
        private string _Name;
        public string Name
        {
            set
            {
                _Name = value;
                RaisePropertyChanged();
            }
            get
            {
                return _Name;
            }
        }
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
        public Command RegisterCommand => new Command(async () => await Register());
        public Command GoToLoginPageCommand => new Command(GoToLoginPage);
        private void GoToLoginPage(object obj)
        {
            CoreMethods.PushPageModel<MainPageModel>();
        }

        private async Task Register()
        {
            var response = await ApiService.Register(Name,UserName, Password);
            if (response)
            {
                await CoreMethods.DisplayAlert("", "Registro exitoso", "Ok");
                await CoreMethods.PushPageModel<MainPageModel>();
            }
            else
            {
                await CoreMethods.DisplayAlert("", "Error al crear cuenta", "Ok");
            }

        }
    }
}
