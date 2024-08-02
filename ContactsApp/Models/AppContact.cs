using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Models
{
    public class AppContact
    {
        private int id;

        private string firstName = "DefaultFirstName";

        private string lastName = "DefaultLastName";

        private string phoneNumber = "5550001111";

        private string eMail = "default@default.com";

        private string address = "default adress";

        private bool isInGroup = false;

        public AppContact() { }

        public AppContact(string FirstName, string LastName, string PhoneNumber, string EMail, string Address)
        {
            this.firstName = FirstName;
            this.LastName = LastName;
            this.phoneNumber = PhoneNumber;
            this.eMail = EMail;
            this.address = Address;
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }

        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }

        public string EMail { get { return eMail; } set { eMail = value; } }
        public string Address { get {    return address; } set { address = value; } }

    }
}
