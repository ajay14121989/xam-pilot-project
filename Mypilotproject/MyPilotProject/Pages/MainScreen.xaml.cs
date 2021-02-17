using MyPilotProject.Models;
using MyPilotProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPilotProject.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainScreen : ContentPage
    {
        public MainScreen()
        {
            var ViewModel = new HotelsGroupViewModel();
            this.BindingContext = ViewModel;
            InitializeComponent();
        }
        private HotelsGroupViewModel ViewModel
        {
            get { return (HotelsGroupViewModel)BindingContext; }
            set { BindingContext = value; }
        }

        private List<Hotel> ListHotel = new List<Hotel>();

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();

                if (ViewModel.Items.Count == 0)
                {
                    ViewModel.LoadHotelsCommand.Execute(null);
                }
            }
            catch (Exception Ex)
            {
                Debug.WriteLine(Ex.Message);
            }
        }


    }
}