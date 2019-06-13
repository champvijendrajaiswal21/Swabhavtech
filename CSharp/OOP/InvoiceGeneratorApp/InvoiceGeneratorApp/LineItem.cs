using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    public class LineItem
    {
        private readonly int _id;
        private readonly Product _product;
        private  int _quantity;

        public LineItem(int id, Product product, int quantity)
        {
            _id = id;
            _product = product;
            _quantity = quantity;

        }

        public int LineItemId
        {
            get
            {
                return _id;
            }
        }
        public int Quantity
        {
            set
            {
                _quantity = value;
            }
            get
            {
                return _quantity;
            }
        }
        public Product PRoduct
        {
            get
            {
                return _product;
            }
        }
        public double TotalItemCost()
        {
            double totalcost=0;
            Console.WriteLine(_product.TotalCost());

            totalcost = _product.TotalCost() * _quantity;
            Console.WriteLine(totalcost);
            return totalcost;
        }
    }
}
