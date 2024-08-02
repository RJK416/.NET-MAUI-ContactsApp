using ContactsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Server
{
    public class AppGroupContactRepository
    {
        public static List<AppGroupContact> groupContacts = new List<AppGroupContact>()
        {
            new AppGroupContact()
            {
                name = "Family",
                GroupContacts = new List<AppContact>
                {
                    new AppContact("Catherine", "Defoe", "123-456-7890", "Defoe@example.com", "Baker 21b"),
                    new AppContact("Jonathan", "Wings", "098-765-4321", "Jonathan@example.com", "Baker 21b"),
                }
            },
        };
    }
}
