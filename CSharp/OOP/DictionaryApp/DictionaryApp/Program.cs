using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DictonaryHandler dictionary = new DictonaryHandler();
            Console.WriteLine("this adding employees");
            dictionary.Add();
            display(dictionary.Employees);

            Console.WriteLine("after updation akash");
            dictionary.Update();
            display(dictionary.Employees);

            Console.WriteLine("after removing dipesh");
            dictionary.Remove();
            display(dictionary.Employees);


            Console.WriteLine("searching james");
            dictionary.search();
        }
        public static void display(Dictionary<int, string> dictionary)
        {
            foreach (KeyValuePair<int, string> employee in dictionary)
            {
                Console.WriteLine("Employee key = " + employee.Key + "Employee value = " + employee.Value);
            }
        }
    }
}
