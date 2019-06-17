using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionViolation
{
   public class FileLogger
    {
      public  void log(string   message)
        {
            Console.WriteLine("file logger");
            Console.WriteLine(message);
        }
    }
}
