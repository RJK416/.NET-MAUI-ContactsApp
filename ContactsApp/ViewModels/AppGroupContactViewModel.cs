using ContactsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ContactsApp.ViewModels
{
    public class AppGroupContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private AppGroupContact AppGroupContact;

        public string Name;

        public List<AppContactViewModel> AppGroupContacts;

        public AppGroupContactViewModel()
        {
        }

        public AppGroupContactViewModel(AppGroupContact GroupContact)
        {
            Name = GroupContact.name;

            AppGroupContacts = new List<AppContactViewModel>();

            foreach (AppContact item in GroupContact.GroupContacts)
            {
                AppGroupContacts.Add(new AppContactViewModel(item));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
