using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserExceptionApp
{
    class NotAkash : Exception
    {
       public NotAkash(string message): base(message)
        {

        }
    }
}
