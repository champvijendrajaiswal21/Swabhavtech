using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountLib;

namespace SubcriberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100,"akash",10000d,"akash@gmail.com",12345678);
             EmailNotification emailnotify = new EmailNotification();
            SmsNotification sms = new SmsNotification();
            account.Subscribe(emailnotify);
            account.Subscribe(sms);
            account.Withdraw(100);
                
        }
    }
}
