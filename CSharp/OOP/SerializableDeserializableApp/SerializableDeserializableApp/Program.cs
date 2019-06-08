using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using AccountApp.Business;

namespace SerializableDeserializableApp
{
    class Program
    {
        private static string path = "C:/SwabhavRespo/CSharp/serializeddata.txt";
       
        static void Main(string[] args)
        {
            Account account1 = new Account(101,"akash",1000);
            Serializable(account1);
            account1.Deposit(1000);


        }
        public static void Serializable(Account account)

        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream filename = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(filename, account);
            filename.Close();
            Console.WriteLine("serialization successful ");

        }
    }
}
