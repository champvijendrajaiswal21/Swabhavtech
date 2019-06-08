using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManagementApp
{
    class CurrentAccount : Account
    {
        private readonly int MIN_BALANCE = -1000;
        public CurrentAccount(string name, int accounnumber, double balance) : base(name, accounnumber, balance,"current account")
        {

        }

      
       public override void Withdraw(double amount)
        {
           
            amount = _balance - amount;

           if(amount > MIN_BALANCE)
                _balance = amount;
            
        }
    }
}
