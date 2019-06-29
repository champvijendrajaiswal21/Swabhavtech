using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountLib
{
    public interface IBalanceChangedNotification
    {
        void Update(Account account);
    }
}
