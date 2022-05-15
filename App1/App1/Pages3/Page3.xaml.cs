using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using App1.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage, INotifyPropertyChanged
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void Reset(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
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
            }
        }
        
        public List<double> list1 = new List<double>();
        public List<double> list2 = new List<double>();
        public double nscore = 1;
        public List<double> round = new List<double>();
        public async void Next_round(object sender, System.EventArgs e)
        {
            try
            {
                
                var sc1 = double.Parse(scoreEntry1.Text);
                var sc2 = double.Parse(scoreEntry2.Text);
                nscore++;
                list1.Add(sc1);
                list2.Add(sc2);
                round.Add(nscore);
                string nscore1 = "Kolo číslo " + round.Last() + ".";
                Round.Text = nscore1;

                
                scoreEntry1.Placeholder = list1.Sum().ToString();
                
                scoreEntry2.Placeholder = list2.Sum().ToString();

                Player player = new Player()
                {
                    pScore1 = scoreEntry1.Text,
                    pScore2 = scoreEntry2.Text
                };

                using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
                {
                    conn.CreateTable<Player>();
                    conn.Insert(player);
                }
            }
            catch (Exception )
            {
                await DisplayAlert("Pozor", "Nezadali jste skóre pro všechny hráče.", "OK");
            }

            scoreEntry1.Text = "";
            scoreEntry2.Text = "";
        }
        void Button_Clicked(object sender, System.EventArgs e)
        {
            Score score = new Score()
            {
                score1 = scoreEntry1.Placeholder,
                score2 = scoreEntry2.Placeholder
            };
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Score>();
                conn.Insert(score);
            }

            App.Current.MainPage = new NavigationPage(new Page4());
        }
    }
}