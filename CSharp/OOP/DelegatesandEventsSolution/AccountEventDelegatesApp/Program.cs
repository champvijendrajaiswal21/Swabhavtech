using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPubisherLib;
namespace AccountEventDelegatesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, "akash", 10000, "akash@gmail.com", 1635647);
            account.BalanceChangeEvent += Sms;
            account.BalanceChangeEvent += Email;
            account.Deposit(500);


        }
        static void Sms(Account account)
        {
            Console.WriteLine("Sms notification");
            Console.WriteLine("balance = "+account.Balance);
        }
        static void Email(Account account)
        {
            Console.WriteLine("email Notification");
            Console.WriteLine("balance = "+account.Balance);
        }
    }
}
