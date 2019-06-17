using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Calculator cal = new Calculator(new FileLogger());
            cal.Calculate(0,0);
            Calculator cal1 = new Calculator(new DBlogger());
            cal1.Calculate(0,0);
        }
    }
}
