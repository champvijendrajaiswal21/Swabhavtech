﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountApp.Business
{
    
  public  class Account
    {
        private int _accountno;
        private string _name;
        private double _balance;
       public static int _count=0;
        static Account()
        {
            _count = 0;
            Console.WriteLine("static constructor");
        }
        public Account ()
        {
            Console.WriteLine(" non static constructor");
        }
        public Account(int accountno , string name, double balance)
        {
            _count++;
            _accountno = accountno;
            _name = name;
            _balance = balance;
        }
        public Account(int accountno , string name ):this (accountno,name,500)
        {

        } 
        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }
        public void Withdraw(double amount)
        {
            amount = _balance - amount;
            if(amount>500)
            {
                _balance = amount;
            }
        }
        public int Accountno
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
        public static int Count
        {
            get
            {
                return _count;
            }
        }
    }
}
