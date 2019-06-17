using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPViolations
{
   public  class Invoice
    {
        private readonly  int _id;
        private readonly  string _name;
        private readonly  double _cost;
        private readonly double _discount;
        private readonly double _gst;

        public Invoice(int id , string name , double cost , double discount , double gst)
        {
            _id = id;
            _name = name;
            _cost = cost;
            _discount = discount;
            _gst = gst;

        }
        public double CostAfterDiscount()
        {
            return _cost - (_cost * _discount);
        }
        public double CalculateTax()
        {
            return _cost * _gst;
        }
        public double  CalculateFinalCost()
        {
            return CostAfterDiscount() + CalculateTax();
        }
       public void Print()
        {
            Console.WriteLine("invoice id "+_id);
            Console.WriteLine("invoice name "+_name);
            Console.WriteLine("cost "+_cost);
            Console.WriteLine("Discount "+_discount);
            Console.WriteLine("gst "+_gst);
            Console.WriteLine(" CostAfterDiscount " + CostAfterDiscount());
            Console.WriteLine(" Calculated Taxt "+CalculateTax());
            Console.WriteLine(" CalculatedFinalCost " + CalculateFinalCost());
        }
    }
}
