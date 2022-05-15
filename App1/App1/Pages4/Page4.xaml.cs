using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using App1.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void Reset(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Page1());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Player>();
                var players = conn.Table<Player>().ToList();

                conn.CreateTable<Score>();
                var scores = conn.Table<Score>().ToList();

                string score1 = scores[scores.Count-1].score1;
                fScore1.Text = score1;

                string score2 = scores[scores.Count-1].score2;
                fScore2.Text = score2;

                playersListView.ItemsSource = players;
            }
        }
    }
}