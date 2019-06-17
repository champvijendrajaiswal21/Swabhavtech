using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalciLib
{
   public class NotEvenException : Exception
    {
        public NotEvenException(string message): base (message)
        {

        }
    }
}
