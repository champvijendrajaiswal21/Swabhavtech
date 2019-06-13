using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    public class Product
    {
        private readonly int _id;
        private readonly string _name;
        private readonly double _discount;
        private readonly double _cost;

        public Product(int id, string name, double discount, double cost)
        {
            _id = id;
            _name = name;
            _discount = discount;
            _cost = cost;
        }
        public double TotalCost()
        {
            double totalcost;
            totalcost = _cost - (_discount * _cost);
            return totalcost;
        }
        public int ProductId
        {
            get
            {
                return _id;
            }
        }
        public string ProductName
        {
            get
            {
                return _name;
            }
        }
        public double ProductDiscount
        {
            get
            {
                return _discount;
            }
        }
        public double ProductCost
        {
            get
            {
                return _cost;
            }
        }
    }
}
