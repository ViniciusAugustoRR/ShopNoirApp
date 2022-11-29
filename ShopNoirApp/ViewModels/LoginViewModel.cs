using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNoirApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string ErrorMessage { get; set; }

        private string _Email;
        private string _Password;

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


        public AsyncCommand Login { get; set; }


        public LoginViewModel()
        {
            Login = new AsyncCommand(_Login);
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
    }
}
