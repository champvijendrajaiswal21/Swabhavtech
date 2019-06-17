using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101, "invoice1", 100000, 0.2, 0.4);
            Print print = new Print(invoice);
            print.PrintInvoice();
        }
    }
}
