using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib;

namespace UnitTestShoppingCart
{
    [TestClass]
    public class OrderTestClass
    {
        [TestMethod]
        public void OrderTestcase()
        {
            Product product = new Product(101, "laptop", 0.3, 45000);
            LineItem Item = new LineItem(201, product, 1);

            Order order = new Order(301, new DateTime(2000, 01, 01));
            order.AddItem(Item);

            Assert.AreEqual(301, order.Id);
            Assert.AreEqual(new DateTime(2000, 01, 01), order.Date);
            LineItem Item2 = new LineItem(201, product, 1);
            order.AddItem(Item2);
            Assert.AreEqual(2, Item.Quantity);
            Assert.AreEqual(63000d, order.Checkoutprice());

        }
        [TestMethod]
        public void AddedOrderItemTesting()
        {
            Product product = new Product(101, "laptop", 0.3, 45000);
            LineItem Item = new LineItem(201, product, 1);
            Product product1 = new Product(101, "bag", 0.3, 4500);
            LineItem Item1 = new LineItem(202, product1, 1);

            Order order = new Order(301, new DateTime(2000, 01, 01));
            order.AddItem(Item);
            order.AddItem(Item1);
            Assert.AreEqual(2, order.Items.Count);


        }
        [TestMethod]
        public void CheckOutPriceTestCase()
        {
            Product product = new Product(101, "laptop", 0.3, 45000);
            LineItem Item = new LineItem(201, product, 1);
            Order order = new Order(301, new DateTime(2000, 01, 01));
            LineItem Item2 = new LineItem(201, product, 1);
            order.AddItem(Item);
            order.AddItem(Item2);
        }



    }
}
    

