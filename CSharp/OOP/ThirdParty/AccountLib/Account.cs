using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPubisherLib
{
    public class Account
    {
        private int _accountno;
        private double _balance;
        private string _name;
        private string _email;
        private int _phoneno;


        public Account(int accountno, string name, double balance, string email, int phoneno)
        {
            _accountno = accountno;
            _name = name;
            _balance = balance;
            _email = email;
            _phoneno = phoneno;


        }
        public void Withdraw(int amount)
        {
            if (_balance > amount)
            {
                _balance = _balance - amount;


            }
        }
        public void Deposit(int amount)
        {
            _balance = _balance + amount;
        }

        public int Id
        {
            get
            {
                return _accountno;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
        }
        public int Phone
        {
            get
            {
                return _phoneno;
            }
        }

    }
}
