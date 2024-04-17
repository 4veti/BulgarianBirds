using App_9_2.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace App_9_2.ViewModels
{
    public class BirdViewModel : INotifyPropertyChanged
    {
        private IBird _selectedBird;

        public BirdViewModel(IEnumerable<IBird> inputBirds)
        {
            Birds = inputBirds;
            SelectedBird = Birds.First();
        }

        public IEnumerable<IBird> Birds { get; private set; }

        public static string CurrentDate => DateTime.Now.ToString("dd MMMM, yyyy", new System.Globalization.CultureInfo("bg"));

        public IBird SelectedBird
        {
            get => _selectedBird;
            set
            {
                if (value != _selectedBird)
                {
                    _selectedBird = value;
                    OnPropertyChanged(nameof(SelectedBird));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
