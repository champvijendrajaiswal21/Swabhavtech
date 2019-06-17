using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalciLib;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calculate = new Calculator();
                calculate.CubeofEvenNumber(-1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
