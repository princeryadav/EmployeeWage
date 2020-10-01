using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AddressBookSystem
{
    public class AddressBookBuilder : IContacts
    {
        private Dictionary<string, Contacts> table;
        public AddressBookBuilder()
        {
            this.table = new Dictionary<string, Contacts>();
        }
        public void AddContacts(string firstName, string lastName, string address, string city, string state, int zip, string phoneNumber)
        {
            Contacts contacts = new Contacts();
            contacts.FirstName = firstName;
            contacts.LastName = lastName;
            contacts.Address = address;
            contacts.City = city;
            contacts.State = state;
            contacts.Zip = zip;
            contacts.PhoneNumber = phoneNumber;
            table.Add(contacts.FirstName, contacts);
        }

        public void DisplayContacts()
        {
            int id = 1;
            TableHelper tableHelper = new TableHelper();
            Console.Clear();
            tableHelper.PrintLine();
            tableHelper.PrintRow("Id","FName", "LName", "Adrs", "City", "State", "Zip", "Phone");
            tableHelper.PrintLine();
            foreach (var item in table)
            {
                tableHelper.PrintRow(id.ToString(),item.Value.FirstName, item.Value.LastName, item.Value.Address,
                item.Value.City, item.Value.State, item.Value.Zip.ToString(), item.Value.PhoneNumber);
                id++;
            }
            tableHelper.PrintLine();
            Console.ReadLine();
        }
    }
}
