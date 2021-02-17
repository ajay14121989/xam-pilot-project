using MyPilotProject.ServicesHandler;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using MyPilotProject.ServicesHandler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPilotProject.Models;
using MyPilotProject.Pages;

namespace MyPilotProject.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public Action DisplayValidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public INavigation Navigation { get; set; }
        public LoginViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
           
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
          
            ButtonLogin_Clicked(email, password);

        }

        private async void ButtonLogin_Clicked(string email, string password)
        {
            LoginService loginService = new LoginService();
            LoginResponseModel getLoginDetails = await loginService.CheckLoginIfExists(email, password);
            if (getLoginDetails.token != null)
            {

                DisplayValidLoginPrompt();
               


            }
            else
            {
                DisplayInvalidLoginPrompt();
            }
        }

     

    }
}