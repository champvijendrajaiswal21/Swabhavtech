using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPSolution
{
   public class FileLogger: ILogger
    {
        public void log(string message)
        {
            Console.WriteLine("file logger");
            Console.WriteLine(message);
        }
    }
}
