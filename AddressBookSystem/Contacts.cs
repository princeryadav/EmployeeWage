using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
    }

    public interface IContacts
    {
        public void AddContacts(string firstName, string lastName, string address, string city, string state, int zip, string phoneNumber);
        public void DisplayContacts();
        public void EditContacts(string firstName, string lastName, string address, string city, string state, int zip, string phoneNumber);
        public void DeleteContacts(string firstName);
    }
}
