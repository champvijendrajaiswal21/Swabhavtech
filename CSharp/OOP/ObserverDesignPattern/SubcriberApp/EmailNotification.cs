using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountLib;


namespace SubcriberApp
{
    class EmailNotification : IBalanceChangedNotification
    {
        public void Update(Account account)
        {
            Console.WriteLine("Email : ");
            Console.WriteLine("Current balance = "+account.Balance);
        }
    }
}
