using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BankManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProxyAccount proxy = new ProxyAccount(1, "account1", 100000, "akash@gmail", 16255474);
                proxy.Withdraw(500);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
