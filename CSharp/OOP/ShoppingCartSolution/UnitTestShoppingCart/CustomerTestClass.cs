using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib;
namespace UnitTestShoppingCart
{
    [TestClass]
    public class CustomerTestClass
    {
        
       
        [TestMethod]
        public void CustomerTestCase()
        {
            Product product = new Product(101, "laptop", 0.5, 45);
            LineItem Item = new LineItem(201, product, 2);
            Order order = new Order(301, new DateTime(2000, 01, 01));
            order.AddItem(Item);
            Customer customer = new Customer(401,"akash","dadar");
            customer.AddOrder(order);
            Assert.AreEqual(401, customer.CustomerId);
            Assert.AreEqual("akash", customer.CustomerName);
            Assert.AreEqual("dadar", customer.CustomerLocation);




        }
       
        
    }
}
