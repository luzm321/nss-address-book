// using System;
using System.Collections.Generic;
// using System.Linq;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Rolodex { get; set; }

        public AddressBook()
        {
            Rolodex = new Dictionary<string, Contact>();
        }

        // method to add a Contact object parameter to the AddressBook class
        public void AddContact(Contact personContact)
        {
            Rolodex.Add(personContact.Email, personContact);
        }

        // method to retrieve contact by email
        public Contact GetByEmail(string email)
        {
            return Rolodex[email];
        }
    }
}