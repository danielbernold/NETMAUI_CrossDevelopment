using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETMAUI_App.ViewModels
{
    public class CardViewModel : INotifyPropertyChanged
    {
        private bool isFavorite;

        public bool IsFavorite
        {
            get => isFavorite;
            set
            {
                if (isFavorite == value) return;
                else
                {
                    isFavorite = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand ToggleCommand => new Command(() =>
        {
            IsFavorite = !IsFavorite;
        });

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
