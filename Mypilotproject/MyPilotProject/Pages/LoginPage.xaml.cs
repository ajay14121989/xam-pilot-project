using MyPilotProject.ViewModels;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;  
using Xamarin.Forms.Xaml;  
  
namespace MyPilotProject.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            vm.DisplayValidLoginPrompt += async () =>
            {
               await Navigation.PushModalAsync(new MainScreen());
            };
            InitializeComponent();
            vm = new LoginViewModel(Navigation);

            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };

            
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainScreen());
        }

        public async Task GotoPage2()
        {
            /////
            await Navigation.PushAsync(new MainScreen());
          
        }
    }
}
