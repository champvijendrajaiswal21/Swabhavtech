using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;


namespace ContactApp
{
    class ContactList
    {
        public static string Filepath = "C:/SwabhavRespo/CSharp/FileContacts.csv";
        public static string path = "C:/SwabhavRespo/CSharp/Demo.txt";
        private List<Contact> _contacts;
        //private ArrayList _contacts;
        public ContactList()
        {
            //_contacts = new ArrayList();
            _contacts = new List<Contact>();
        }

        public void AddContact(string name, string email, int phoneno)
        {
            _contacts = GettingContacts();
            Contact contact = new Contact(name, email, phoneno);
            _contacts.Add(contact);
            SavingContacts(_contacts);
        }

        public List<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
        }

        public static void SavingContacts(List<Contact> list)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, list);
            }

        }

        public static List<Contact> GettingContacts()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Contact>)formatter.Deserialize(fs);
            }
        }

        public List<Contact> SearchContact(string searchContact)
        {
            _contacts = GettingContacts();
            List<Contact> matchingcontact = new List<Contact>();

            
            foreach (Contact contact in _contacts)
            {
                if ((contact.Name).Equals(searchContact) || (contact.Email).Equals(searchContact) || (contact.Phoneno.ToString()).Equals(searchContact))
                {
                    matchingcontact.Add(contact);
                }
            }

            return matchingcontact;
        }
        public void Export()
        {
            _contacts = GettingContacts();
            StringBuilder builder = new StringBuilder();
            foreach (Contact contact in _contacts)
            {
                builder.AppendLine(contact.Name + "," + contact.Email + "," + contact.Phoneno);
            }
            File.WriteAllText(Filepath, builder.ToString());

        }
    }
}
