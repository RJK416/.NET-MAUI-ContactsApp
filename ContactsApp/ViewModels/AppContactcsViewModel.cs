using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Models;
using ContactsApp.Server;

namespace ContactsApp.ViewModels
{
    public class AppContactcsViewModel
    {

        private List<AppContact> _contacts;
        public List<AppContactViewModel> ContactsVM { get; private set; }

        public AppContactcsViewModel()
        {
            // Initialize the contacts list
            _contacts = AppContactRepository.Contacts;

            // Initialize ContactsVM
            ContactsVM = new List<AppContactViewModel>();

            // Populate ContactsVM with AppContactViewModel instances
            foreach (AppContact contact in _contacts)
            {
                // Assuming AppContactViewModel has a constructor that accepts an AppContact

                ContactsVM.Add(new AppContactViewModel(contact));
            }


        }
    }
}
