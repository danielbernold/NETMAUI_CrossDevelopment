using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NETMAUI_App.ViewModels
{
    public class HomeViewModel
    {
        public ICommand GoToDetailCommand { get; }

        public HomeViewModel()
        {
            GoToDetailCommand = new Command(async () =>
            {
                // Navigation mit Parameter
                await Shell.Current.GoToAsync($"detail?text=HalloAusMaui");
            });
        }
    }
}
