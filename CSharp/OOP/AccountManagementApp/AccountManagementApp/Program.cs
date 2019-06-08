using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new CurrentAccount("akash", 101, 10000.00d);
            Account account2 = new SavingAccount("dhruv", 102, 10500.0d);

            DisplayDetails(account1);
            DisplayDetails(account2);
            account2.Deposit(1000);
            account2.Withdraw(1200);

         
            DisplayDetails(account2);
        }
        static void DisplayDetails(Account account)
        {
            Console.WriteLine(" Name = " + account.Name);
            Console.WriteLine("Account Number = " + account.Number);
            Console.WriteLine("Balance = " + account.Balance);
            Console.WriteLine("type = "+account.Type);
        }
    }
}
