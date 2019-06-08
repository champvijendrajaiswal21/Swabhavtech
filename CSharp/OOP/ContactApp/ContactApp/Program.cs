using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email;
            int phoneno;
            ContactList contacts = new ContactList();
            int ch = 0;
            do
            {
                Console.WriteLine(" enter 1 : to add contact");
                Console.WriteLine("enter 2 : to display");
                Console.WriteLine("enter 3: to export");
                Console.WriteLine("enter 4: to search");
                Console.WriteLine("enter 5 : to exit");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("enter the name");
                        name = Console.ReadLine();
                        Console.WriteLine("enter the email");
                        email = Console.ReadLine();
                        Console.WriteLine("enter phone no");
                        phoneno = Convert.ToInt32(Console.ReadLine());
                        contacts.AddContact(name, email, phoneno);

                        break;
                    case 2:
                        DisplayContactlist(ContactList.GettingContacts());
                        break;
                    case 3:
                        contacts.Export();
                        break;
                    case 4:
                        Console.WriteLine("enter name or email or phoneno");
                        string search = Console.ReadLine();
                        DisplayContactlist(contacts.SearchContact(search));
                      
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            } while (ch != 5);
        }
        static void DisplayContactlist(List<Contact> contactarray)
        {
          
            foreach(Contact contact in contactarray)
            { 
                Console.WriteLine("name = " + contact.Name);
                Console.WriteLine("Email = " + contact.Email);
                Console.WriteLine("Phone = " + contact.Phoneno);
            }
        }


    }
}
