using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Models;

namespace ContactsApp.Server
{
    public class AppContactRepository
    {
        private static readonly List<AppContact> _contacts = new List<AppContact>()
        {
            new AppContact("John", "Doe", "123-456-7890", "john.doe@example.com", "123 Elm Street"),
            new AppContact("Jane", "Smith", "098-765-4321", "jane.smith@example.com", "456 Oak Avenue"),
            new AppContact("Mariah", "Garcia", "598-765-4321", "Mariah.Garcia@example.com", "23 Oak Avenue"),
            new AppContact("Judah", "Jebedaiah", "594-094-2331", "Mariah.Garcia@example.com", "23 Oak Avenue"),
        };

        public static List<AppContact> Contacts  = _contacts;

    }
}
