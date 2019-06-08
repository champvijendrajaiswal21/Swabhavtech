using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("akash", "jaiswal");
            Customer customer2 = new Customer("dhruv", "jaiswal");
            Customer customer3 = new Customer("sanal", "jaiswal");
            PrintId(customer1);
            PrintId(customer2);
            PrintId(customer3);
        }
        public static void PrintId(Customer customer)
        {
            Console.WriteLine("customer id "+customer.ID);
        }

    }
}
