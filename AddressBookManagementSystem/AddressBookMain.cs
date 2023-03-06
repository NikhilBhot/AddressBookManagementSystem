using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagementSystem
{
    public class AddressBookMain
    {
        public static Contacts contact = new Contacts();
        public static List<Contacts> Person = new List<Contacts>();
        public  static  void CreateContact()
        {
            Console.WriteLine("Enter Your First Name : ");
            contact.fName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name : ");
            contact.lName = Console.ReadLine();
            Console.WriteLine("Enter Your Address : ");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter Your City : ");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter Your State : ");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter Your Zip Code : ");
            contact.zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Phone No : ");
            contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Your Email : ");
            contact.email = Console.ReadLine();

            Program.Person.Add(contact);

        }
    }
}