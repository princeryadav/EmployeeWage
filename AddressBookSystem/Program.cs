using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program!");
            AddressBookBuilder bookBuilder = new AddressBookBuilder();
            bookBuilder.AddContacts("Prince", "Yadav", "Manorma", "Thane", "MH", 400607, "808082801");
            bookBuilder.AddContacts("Indal", "Yadav", "Manorma", "Thane", "MH", 400607, "808082801");
            bookBuilder.AddContacts("Sam", "Yadav", "Manorma", "Thane", "MH", 400607, "808082801");
            bookBuilder.AddContacts("Curon", "Yadav", "Manorma", "Thane", "MH", 400607, "808082801");
            bookBuilder.DisplayContacts();
            bookBuilder.EditContacts("Sam", "Shem", "MU", "London", "Eng", 14512, "808082801");
            bookBuilder.EditContacts("Indal", "Shem", "MU", "London", "Eng", 14512, "808082801");
            bookBuilder.EditContacts("Prince", "Shem", "MU", "London", "Eng", 14512, "808082801");
            bookBuilder.DisplayContacts();
            bookBuilder.DeleteContacts("Prince");
            bookBuilder.DisplayContacts();
        }
    }
}
