using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPubisherLib;

namespace BankManagement
{
    class ProxyAccount : Account
    {
        public ProxyAccount(int accountno, string name, double balance, string email, int phoneno) : base(accountno, name, balance, email, phoneno)
        {
        }
        public void Withdraw(int amount)
        {
            Console.WriteLine("balance before withdraw = " + base.Balance);
            Console.WriteLine(DateTime.Now);
            base.Withdraw(amount);
            Console.WriteLine("balance before withdraw = " + base.Balance);
            Console.WriteLine(DateTime.Now);

        }


    }
}
