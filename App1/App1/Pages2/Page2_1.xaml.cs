using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2_1 : ContentPage
    {
        public Page2_1()
        {
            InitializeComponent();
        }
        void Return_Clicked(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Page1());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry1.Text) && !string.IsNullOrWhiteSpace(nameEntry2.Text) && !string.IsNullOrWhiteSpace(nameEntry3.Text))
            {
                Player player = new Player()
                {
                    pName1 = nameEntry1.Text,
                    pName2 = nameEntry2.Text,
                    pName3 = nameEntry3.Text
                };

                using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
                {
                    conn.DropTable<Player>();
                    conn.CreateTable<Player>();
                    int rowsAdded = conn.Insert(player);
                }
                App.Current.MainPage = new NavigationPage(new Page3_1());
            }
            else
            {
                DisplayAlert("Pozor", "Nevyplnili jste všechna jména.", "OK");
            }
            
        }
    }
}