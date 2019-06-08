using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashsetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashsetHandler dictionary = new HashsetHandler();
            Console.WriteLine("this adding employees");
            dictionary.Add();
            display(dictionary.Employees);



            Console.WriteLine("after removing dipesh");
            dictionary.Remove();
            display(dictionary.Employees);


            Console.WriteLine("searching akash");
            dictionary.Search();
        }
        public static void display(HashSet<string> hashset)
        {
            foreach (String employee in hashset)
            {
                Console.WriteLine("Employee name = " + employee);
            }
        }
    }
}

