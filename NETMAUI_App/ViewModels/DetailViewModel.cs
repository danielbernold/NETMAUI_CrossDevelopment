using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace NETMAUI_App.ViewModels
{
    [QueryProperty(nameof(Text), "text")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private string text;

        public ICommand GoBackCommand { get; }

        public DetailViewModel()
        {
            GoBackCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("..");
            });
        }
    }
}
