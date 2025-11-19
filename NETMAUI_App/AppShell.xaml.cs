using NETMAUI_App.Views;

namespace NETMAUI_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("detail", typeof(DetailPage));
        }
    }
}
