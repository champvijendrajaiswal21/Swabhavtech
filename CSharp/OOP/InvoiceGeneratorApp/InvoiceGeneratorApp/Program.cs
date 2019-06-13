using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Product product1 = new Product(100, "Laptop", 0.5, 1000000);
                Product product2 = new Product(102, "Tv", 0.2, 123000);
                Product product3 = new Product(103, "bag", 0.45, 2000);
                LineItem lineitem1 = new LineItem(202, product1, 1);
                LineItem lineitem4 = new LineItem(202, product1, 1);
                LineItem lineitem2 = new LineItem(201, product2, 1);
                LineItem lineitem3 = new LineItem(203, product3, 3);
                Order order = new Order(301, new DateTime(2019, 05, 10));
                Order order1 = new Order(302, new DateTime(2019, 02, 05));
                Customer dhruv = new Customer(402, "dhruv", "thane");
                order.AddItem(lineitem1);
                order.AddItem(lineitem2);
                order.AddItem(lineitem4);
                order1.AddItem(lineitem2);
                order1.AddItem(lineitem3);
                dhruv.AddOrder(order);
                dhruv.AddOrder(order1);
                Summary(dhruv);
               
              
               

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
     private static void Summary(Customer customer)
        {
           foreach (Order order in customer.OrderList)
            {
                Console.WriteLine("order id = "+order.Id);
                Console.WriteLine("order date = "+order.Date);
                foreach (LineItem item in order.Items)
                {
                    Console.WriteLine("line item id = "+item.LineItemId);
                    Console.WriteLine("Quantity = "+item.Quantity);
                    Console.WriteLine("product id = "+item.PRoduct.ProductId);
                    Console.WriteLine("product name = "+item.PRoduct.ProductName);
                    Console.WriteLine("discount = "+item.PRoduct.ProductDiscount);
                    Console.WriteLine("cost =  "+item.PRoduct.ProductCost);
                }
                Console.WriteLine("total cost = "+order.Checkoutprice());
            }
           
        }
       
    }
}
