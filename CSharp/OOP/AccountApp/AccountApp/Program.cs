using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountApp.Business;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Account account1 = new Account(1,"Akash",2000d);
            account1.Withdraw(600);
            PrintInfo(account1);
            Account account2 = new Account(2,"Dhruv");
            account2.Withdraw(600);

            PrintInfo(account2);

        }
        public static void PrintInfo(Account ac)
        {
            Console.WriteLine(" count ="+Account.Count );
            Console.WriteLine("Account no = "+ac.Accountno);
            Console.WriteLine(" Name = "+ac.Name);
            Console.WriteLine(" Balance = "+ac.Balance);
        }
    }
}
