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
            contact.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your Email : ");
            contact.email = Console.ReadLine();

            Program.Person.Add(contact);

        }

        public static void Dispaly()
        {
            foreach (var contact in Program.Person)
            {
                Console.WriteLine("First Name : " + contact.fName + "\nLast Name : " + contact.lName + "\naddress : " + contact.address + "\nCity : " + contact.city + "\nState : " + contact.state + "\nZipCode : " + contact.zipcode + "\nPhone Number : " + contact.phoneNumber + "\nEmail : " + contact.email);
            }
        }
        public static void EditContact()
        {
            Console.WriteLine("Edit a contact list enter first name");

            string name = Console.ReadLine();

            if (contact.fName == name)
            {
                Console.WriteLine("Edit a Contact\n 1.lastName\n 2.Address\n 3.City\n 4.State\n 5.Zip\n 6.phone no\n 7.email");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string lastName = Console.ReadLine();
                        contact.lName = lastName;
                        break;
                    case 2:
                        string address = Console.ReadLine();
                        contact.address = address;
                        break;
                    case 3:
                        string city = Console.ReadLine();
                        contact.city = city;
                        break;
                    case 4:
                        string state = Console.ReadLine();
                        contact.state = state;
                        break;
                    case 5:
                        string zipcode = Console.ReadLine();
                        contact.zipcode = Convert.ToInt32(zipcode);
                        break;
                    case 6:
                        string phoneNo = Console.ReadLine();
                        contact.phoneNumber = Console.ReadLine();
                        break;
                    case 7:
                        string email = Console.ReadLine();
                        contact.email = email;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Name is not Exist");
            }

        }
    }
}