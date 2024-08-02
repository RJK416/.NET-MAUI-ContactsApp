using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Models
{
    public class AppGroupContact
    {
        private int id;

        public string name;

        public List<AppContact> GroupContacts = new List<AppContact>();
    }
}
