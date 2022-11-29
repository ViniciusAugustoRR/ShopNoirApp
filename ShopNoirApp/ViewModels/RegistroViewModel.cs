using MvvmHelpers.Commands;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNoirApp.ViewModels
{
    public class RegistroViewModel : BaseViewModel
    {
        private string _Name;
        private string _Email;
        private string _Password;
        private string _ConfirmPassword;


        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }
        public string Email
        {
            get => _Email;
            set => SetProperty(ref _Email, value);
        }
        public string Password
        {
            get => _Password;
            set => SetProperty(ref _Password, value);
        }
        public string ConfirmPassword
        {
            get => _ConfirmPassword;
            set => SetProperty(ref _ConfirmPassword, value);
        }

        public AsyncCommand GoToLogin { get; set; }
        public AsyncCommand Register { get; set; }



        public async Task _Register()
        {
            if (VerifyRegister())
            {
                await Shell.Current.GoToAsync("//MainPage");
            }
            else
            {

            }

        }

        public async Task _Login()
        {
            if (VerifyLogin())
            {
                await Shell.Current.GoToAsync("//MainPage");
            }
            else
            {
                //ERRO MESSAGE
            }
        }

        public bool VerifyLogin()
        {
            //CALL SERVICE AND VERIFY EMAIL AND PASSWORD
            //IF USER FOUND RETURN TRUE ELSE FALSE
            return true;
        }
        private bool VerifyRegister()
        {
            if (_Password.Equals(_ConfirmPassword))
                return true;

            return false;
        }
    }
}
