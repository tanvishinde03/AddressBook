using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AddressBook addressbook = new AddressBook();
            bool free = true;
            while (free)
            {
                Console.WriteLine("Select 1: For Creating Contact\n");
                   Console.WriteLine("Select 2: Edit Existing Contact\n");
                Console.WriteLine("Select 3: Display Contact\n");
                Console.WriteLine("Select Option");
                
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        addressbook.AddContact();
                        addressbook.Display();

                        break;
                    case 2:
                       string name = Console.ReadLine();
                        addressbook.EditContact( name);
                        addressbook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Display Contact Details");
                        addressbook.Display();
                        Console.ReadLine();

                        break;
                    case 4:
                        free = false;
                        break;
                }
            }
        }

    }
}