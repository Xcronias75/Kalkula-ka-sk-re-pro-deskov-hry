using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new Page1ViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Output.Text == "2")
            {
                App.Current.MainPage = new NavigationPage(new Page2());
            }
            else if (Output.Text == "3")
            {
                App.Current.MainPage = new NavigationPage(new Page2_1());
            }
            else if (Output.Text == "4")
            {
                App.Current.MainPage = new NavigationPage(new Page2_2());
            }
            else if (Output.Text == "5")
            {
                App.Current.MainPage = new NavigationPage(new Page2_3());
            }
            else if (Output.Text == "6")
            {
                App.Current.MainPage = new NavigationPage(new Page2_4());
            }

        }
    }
}