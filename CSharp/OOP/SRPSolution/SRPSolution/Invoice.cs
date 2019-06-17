using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPSolution
{
    public class Invoice
    {


        private readonly int _id;
        private readonly string _name;
        private readonly double _cost;
        private readonly double _discount;
        private readonly double _gst;

        public Invoice(int id, string name, double cost, double discount, double gst)
        {
            _id = id;
            _name = name;
            _cost = cost;
            _discount = discount;
            _gst = gst;

        }
        public int ID
            {
            get
            {
                return _id;
            }
            }
        public string Name 
            {
            get
            {
                return _name;
            }
            }
        public double Cost
             {
            get
            {
                return _cost;
            }
            }
        public double Discount 
            {
            get
            {
                return _discount;
            }
            }
        public double Gst
            {
            get
            {
                return _gst;
            }
            }
    public double CostAfterDiscount()
            {
                return _cost - (_cost * _discount);
            }
            public double CalculateTax()
            {
                return _cost * _gst;
            }
            public double CalculateFinalCost()
            {
                return CostAfterDiscount() + CalculateTax();
            }

        }
    }
