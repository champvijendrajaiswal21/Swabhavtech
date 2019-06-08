using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManagementApp
{
    public abstract class Account
    {
        private string _accountname;
        private int _accountnumber;
        protected double _balance;
        protected string _type;

        public Account(string name, int accounnumber, double balance, string accounttype)
        {
            _accountname = name;
            _accountnumber = accounnumber;
            _balance = balance;
            _type = accounttype;
        }

        public string Name
        {
            get
            {
                return _accountname;
            }
        }
        public int Number

        {
            get
            {
                return _accountnumber;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
        }
       public void Deposit(double balance)
        {
            _balance = _balance + balance;
        }
        public abstract void Withdraw(double amount);
        

        

    }
}
