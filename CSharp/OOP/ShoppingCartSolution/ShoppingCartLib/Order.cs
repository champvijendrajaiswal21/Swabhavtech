using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ShoppingCartLib
{
     public class Order
        {
            private readonly int _id;
            private readonly DateTime _date;
            private List<LineItem> _items;

            public Order(int id, DateTime date)
            {
                _id = id;
                _date = date;
                _items = new List<LineItem>();
            }

            public List<LineItem> Items
            {
                get
                {
                    return _items;
                }
            }
            public int Id
            {
                get
                {
                    return _id;
                }
            }
            public DateTime Date
            {
                get
                {
                    return _date;
                }
            }

            public void AddItem(LineItem item)
            {
                int flag = 0;
                foreach (LineItem items in _items)
                {
                    if (items.LineItemId == item.LineItemId)
                    {
                        items.Quantity = items.Quantity + item.Quantity;
                        flag = 1;
                        break;
                    }
                }
                if (flag != 1)
                {

                    _items.Add(item);
                }
            }


            public double Checkoutprice()
            {
                double total = 0;
                foreach (LineItem lineitem in _items)
                {
                    total = total + lineitem.TotalItemCost();

                }
                return total;
            }


        }
    }
