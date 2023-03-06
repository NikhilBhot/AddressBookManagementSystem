using AddressBookManagementSystem;

namespace AddressBookManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address Book System");
           /*UC-01 Ability to create a Contacts in Address Book with first and last names, address,city, state, zip, 
            phone number and email...
           */
            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.CreatContact();
        }
    }
}