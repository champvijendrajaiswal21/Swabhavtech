using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartLib
{
    public class Customer
    {
        private readonly int _id;
        private readonly string _name;
        private readonly string _location;
        private List<Order> _orders;

        public Customer(int id, string name, string location)
        {
            _id = id;
            _name = name;
            _location = location;
            _orders = new List<Order>();
        }
        public List<Order> OrderList
        {
            get
            {
                return _orders;
            }
        }
        public int CustomerId
        {
            get
            {
                return _id;
            }
        }
        public string CustomerName
        {
            get
            {
                return _name;
            }
        }
        public string CustomerLocation
        {
            get
            {
                return _location;
            }
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
    }

}
