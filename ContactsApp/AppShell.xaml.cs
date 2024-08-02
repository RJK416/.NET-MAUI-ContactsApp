using ContactsApp.Views;

namespace ContactsApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ContactMainPage), typeof(ContactMainPage));
        }
    }
}
