using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankersExceptionApp;

namespace AccountManagementApp
{
    public class Account
    {
        private readonly string _accountname;
        private readonly int _accountnumber;
        private  double _balance;
        private readonly string _type;

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

        public  void Withdraw(double amount)
        {
            double amount1;
            amount1 = _balance-amount;
            if(amount1 < 500)
            {
                throw new InsufficientFundException(this , amount);
            }
            else
            {
                _balance = amount1;
            }
        }
        }
}
