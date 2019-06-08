using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calci = new Calculate(20,-30);
            Console.WriteLine("result = "+calci.Addition());
        }
    }
}
