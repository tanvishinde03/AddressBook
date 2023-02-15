using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook
{
    public class AddressBook
    {
        Contact contact = new Contact();

        public void AddContact()
        {
          contact.FirstName= Console.ReadLine();
            contact.LastName= Console.ReadLine();
            contact.Email= Console.ReadLine();
            contact.PhoneNumber = Console.ReadLine();
            contact.Address= Console.ReadLine();
            contact.City= Console.ReadLine();
            contact.state = Console.ReadLine();
            contact.Zip=Convert.ToInt64(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Contact Details" + "\n" + "First Name" + contact.FirstName + "\n" + "LastName" + contact.LastName + "\n" + "Email" + contact.Email + "\n" + "city" + contact.City + "\n" + "PhoneNumber" + contact.PhoneNumber + "\n" + "Address" + "contact.Address" + "\n" + "zip" + "contact.zip");
           
        }







    }
}
