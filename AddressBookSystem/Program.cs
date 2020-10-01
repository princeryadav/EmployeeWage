using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program!");
            AddressBookBuilder bookBuilder = new AddressBookBuilder();
            bookBuilder.AddContacts("Prince","Yadav","Manorma","Thane","MH",400607,"808082801");
            bookBuilder.DisplayContacts();
        }
    }
}
