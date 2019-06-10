using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountManagementApp; 

namespace BankersExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account("akash", 1001, 2000, "saving");
                account.Withdraw(200000);
            }
            catch(Exception exception )
            {
                Console.WriteLine(exception.Message);
            }
            }
    }
}
