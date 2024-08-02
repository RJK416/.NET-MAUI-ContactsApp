using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.ViewModels
{
    public class CompositeViewModel
    {
        public AppGroupContactsViewModel GroupContactsVM { get; set; }
        public AppContactcsViewModel ContactsVM { get; set; }

        public CompositeViewModel()
        {
            GroupContactsVM = new AppGroupContactsViewModel();
            ContactsVM = new AppContactcsViewModel();
        }


    }
}
