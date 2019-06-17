using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionViolation
{
   public class DBLogger
    {
       public void log(string message)
        {
            Console.WriteLine("database logger");
            Console.WriteLine(message);

        }
    }
}
