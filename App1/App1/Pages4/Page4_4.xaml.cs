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
    public partial class Page4_4 : ContentPage
    {
        public Page4_4()
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
                string player1 = players[0].pName1;
                Player1.Text = player1;

                string player2 = players[0].pName2;
                Player2.Text = player2;

                string player3 = players[0].pName3;
                Player3.Text = player3;

                string player4 = players[0].pName4;
                Player4.Text = player4;

                string player5 = players[0].pName5;
                Player5.Text = player5;

                string player6 = players[0].pName6;
                Player6.Text = player6;

                conn.CreateTable<Score>();
                var scores = conn.Table<Score>().ToList();

                string score1 = scores[scores.Count - 1].score1;
                fScore1.Text = score1;

                string score2 = scores[scores.Count - 1].score2;
                fScore2.Text = score2;

                string score3 = scores[scores.Count - 1].score3;
                fScore3.Text = score3;

                string score4 = scores[scores.Count - 1].score4;
                fScore4.Text = score4;

                string score5 = scores[scores.Count - 1].score5;
                fScore5.Text = score5;

                string score6 = scores[scores.Count - 1].score6;
                fScore6.Text = score6;

                playersListView.ItemsSource = players;
            }
        }
    }
}