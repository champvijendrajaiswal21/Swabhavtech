using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApp
{
    class LineItem
    {
        private string _productname;
        private int _quantity;
        private double _unitprice;
        
        public LineItem(string productname , int quantity , double price )
        {
            _productname = productname;
            _quantity = quantity;
            _unitprice = price;
        } 
        public string  ProductName
            {
            get
            {
                return _productname;
            }
            }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }
        public double Unitprice
        {
            get
            {
                return _unitprice;
            }
        }

        public double CalculateTotal()
        {
            return _quantity * _unitprice;
        }

        public override bool Equals(object obj)
        {
            LineItem item = (LineItem)obj;
            if (item.ProductName == this.ProductName&& item._quantity == this._quantity && item._unitprice == this._unitprice)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

    }
}
