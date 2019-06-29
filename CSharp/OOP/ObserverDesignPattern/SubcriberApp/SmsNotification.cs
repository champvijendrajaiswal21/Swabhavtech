using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountLib;


namespace SubcriberApp
{
    class SmsNotification : IBalanceChangedNotification
    {
        public void Update(Account account)
        {
            Console.WriteLine("SMS : ");
            Console.WriteLine("Current balance = " + account.Balance);
        }
    }
}
