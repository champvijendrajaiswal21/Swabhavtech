﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountLib
{
  public  class Account
    {
        private readonly int _accountnumber;
        private readonly string _name;
        private readonly double _mobilenumber;
        private readonly string _email;
        private double _balance;
        private List<IBalanceChangedNotification> _subcriberlist;

        public Account(int accountno, string name, double mobno, string email, double balance)
        {
            _accountnumber = accountno;
            _name = name;
            _mobilenumber = mobno;
            _email = email;
            _balance = balance;
            _subcriberlist = new List<IBalanceChangedNotification>();
        }

        public int AccountNumber
        {
            get { return _accountnumber; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Email
        {
            get { return _email; }
        }

        public double MobileNumber
        {
            get { return _mobilenumber; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public void Withdraw(double amount)
        {
            if ((Balance < 500) && (Balance - amount) < 500)
                return;
            _balance -= amount;
            Notify();
        }

        public void Deposite(double amount)
        {
            _balance += amount;
            Notify();
        }

        public void Subscribe(IBalanceChangedNotification subcriber)
        {
            _subcriberlist.Add(subcriber);
        }

        public void Unsubscribe(IBalanceChangedNotification subcriber)
        {
            _subcriberlist.Remove(subcriber);
        }

        public void Notify()
        {
            foreach (IBalanceChangedNotification subcriber in _subcriberlist)
                subcriber.Update(this);
        }
    }
}
