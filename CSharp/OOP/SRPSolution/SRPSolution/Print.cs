using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPSolution
{
   public class Print
    {
        private Invoice invoice;
        public Print(Invoice invoice)
        {
            this.invoice = invoice;
        }
       public void PrintInvoice()
        {
            Console.WriteLine("invoice id " + invoice.ID);
            Console.WriteLine("invoice name " + invoice.Name);
            Console.WriteLine("cost " + invoice.Cost);
            Console.WriteLine("Discount " + invoice.Discount);
            Console.WriteLine("gst " + invoice.Gst);
            Console.WriteLine(" CostAfterDiscount " + invoice.CostAfterDiscount());
            Console.WriteLine(" Calculated Taxt " + invoice.CalculateTax());
            Console.WriteLine(" CalculatedFinalCost " + invoice.CalculateFinalCost());

        }
    }
}
