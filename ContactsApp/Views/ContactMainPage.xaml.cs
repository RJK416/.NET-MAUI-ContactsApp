using Microsoft.Maui.Controls;
using ContactsApp.ViewModels;
using ContactsApp.Models;

namespace ContactsApp.Views
{
    public partial class ContactMainPage : ContentPage
    {
        public ContactMainPage()
        {
            InitializeComponent();
            BindingContext = new CompositeViewModel();
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
