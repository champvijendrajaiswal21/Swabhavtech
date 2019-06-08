using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManagementApp
{
    class SavingAccount : Account
    {
        private readonly int MIN_BALANCE = 1000;
        public SavingAccount(string name, int accounnumber, double balance) : base(name, accounnumber, balance,"Saving account")
        {
        }

        public override void Withdraw(double amount)
        {
            
                amount = _balance - amount;
                if (amount > 10)
                {
                    _balance = amount;
                }
            
        }
    }
}
