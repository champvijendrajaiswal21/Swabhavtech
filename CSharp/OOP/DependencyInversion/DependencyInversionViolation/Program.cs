using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                TaxCalculator taxcalculator = new TaxCalculator(LogType.DB);
                taxcalculator.Calculate(0, 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message  );
            }
        }
    }
}
