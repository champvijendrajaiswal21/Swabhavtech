using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPSolution
{
  public  class DBlogger :ILogger
    {
        public void log(string message) 
        {
            Console.WriteLine("database logger");
            Console.WriteLine(message);

        }
    }
}
