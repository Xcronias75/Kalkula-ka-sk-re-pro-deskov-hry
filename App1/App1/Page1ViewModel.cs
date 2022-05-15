using System;
using System.ComponentModel;

namespace App1
{
    internal class Page1ViewModel : INotifyPropertyChanged
    {
        public double player = 2;
        
        public double Cislovydat
        {
            get
            {
                return player;
            }
            
        }

        public double Player
        {
            get => player;
            set
            {
                player = NextStep(value);
                UpdateResults();
            }
        }

        public double PlayerNumber
            => Math.Round(Player);

        public string Classification
        {
            get
            {
                if (PlayerNumber <= 4)
                    return "Hráče.";
                else
                    return "Hráčů.";
            }
        }

        private void UpdateResults()
        {
            RaisePropertyChanged(nameof(PlayerNumber));
            RaisePropertyChanged(nameof(Classification));
            RaisePropertyChanged(nameof(Cislovydat));
        }

        private double NextStep(double value)
            => Math.Round(value);

        private void RaisePropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler PropertyChanged;
    }
}