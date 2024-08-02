using ContactsApp.Models;
using ContactsApp.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.ViewModels
{
    public class AppGroupContactsViewModel
    {
        public List<AppGroupContactViewModel> GroupContactsVM;

        private List<AppGroupContact>? _contacts;

        public AppGroupContactsViewModel()
        {
            _contacts = AppGroupContactRepository.groupContacts;


            GroupContactsVM = new List<AppGroupContactViewModel>();

            if (_contacts is not null )
            {
                foreach(AppGroupContact contact in _contacts)
                {
                    GroupContactsVM.Add(new AppGroupContactViewModel(contact));
                }  
            }
  
        }



    }
}
