using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesApp
{
    public delegate void DPrintMessage(string message);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage print,multicast=PrintHello;
            print = PrintHello;
            print("akash");
            print = PrintGoodbye;
            print("akash");
            PrintWizard(PrintGoodbye);
            multicast += PrintGoodbye;
            multicast("akash");


        }
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
        static void PrintGoodbye(string name)
        {
            Console.WriteLine("goodbye {0}", name);
        }
        static void PrintWizard(DPrintMessage message)
        {
            message("champ");
        }
    }
}
