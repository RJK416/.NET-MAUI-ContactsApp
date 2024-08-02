using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Models;

namespace ContactsApp.ViewModels
{
    public class AppContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private AppContact contact;


        public AppContactViewModel()
        {
        }

        public AppContactViewModel(AppContact contact)
        {
            this.contact = contact ?? throw new ArgumentNullException(nameof(contact));
        }

        public string FirstName
        {
            get
            {
                return contact.FirstName;
            }

            set
            {
                if (contact.FirstName != value)
                {
                    contact.FirstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }

        public string LastName
        {
            get
            {
                return contact.LastName;
            }

            set
            {
                if (contact.LastName != value)
                {
                    contact.LastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return contact.PhoneNumber;
            }

            set
            {
                if (contact.PhoneNumber != value)
                {
                    contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        public string EMail
        {
            get
            {
                return contact.EMail;
            }

            set
            {
                if (contact.EMail != value)
                {
                    contact.EMail = value;
                    OnPropertyChanged(nameof(EMail));
                }
            }
        }

        public string Address
        {
            get
            {
                return contact.Address;
            }

            set
            {
                if (contact.Address != value)
                {
                    contact.Address = value;
                    OnPropertyChanged(nameof(Address));
                }
            }
        }



        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    
}
