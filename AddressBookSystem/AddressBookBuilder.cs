using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AddressBookSystem
{
    public class AddressBookBuilder : IContacts
    {
        private Contacts contacts;
        public AddressBookBuilder()
        {
            this.contacts = new Contacts();
        }
        public void AddContacts(string firstName, string lastName, string address, string city, string state, int zip, string phoneNumber)
        {
            this.contacts.FirstName = firstName;
            this.contacts.LastName = lastName;
            this.contacts.Address = address;
            this.contacts.City = city;
            this.contacts.State = state;
            this.contacts.Zip = zip;
            this.contacts.PhoneNumber = phoneNumber;
        }

        public void DisplayContacts()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", this.contacts.FirstName, this.contacts.LastName, this.contacts.Address,
                this.contacts.City, this.contacts.State,this.contacts.Zip,this.contacts.PhoneNumber);

        }
    }
}
