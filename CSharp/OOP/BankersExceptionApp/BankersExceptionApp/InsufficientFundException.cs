using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountManagementApp;

namespace BankersExceptionApp
{
    public class InsufficientFundException : Exception
    {
        private readonly Account _account;
        private readonly double _amount;
        public InsufficientFundException(Account account, double amount)
        {
            _account = account;
            _amount = amount;
        }
        public override string Message
        {
            get
            {
                return "Name = " + _account.Name + "\n ID = " + _account.Number +
                    "\n your account balance is " + _account.Balance +
                    "\nso it Insufficient fund exception because withdraw amount is " + _amount;
            }
        }

    }
}
