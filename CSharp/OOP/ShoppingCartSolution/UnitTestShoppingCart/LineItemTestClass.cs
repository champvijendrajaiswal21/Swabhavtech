using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib;

namespace UnitTestShoppingCart
{
    [TestClass]
    public class LineItemTestClass
    {
        [TestMethod]
        public void LineItemTestcase()
        {
            Product product = new Product(101, "laptop", 0.3, 45000);
            LineItem Item = new LineItem(201, product, 2);
            Assert.AreEqual(201, Item.LineItemId);
            Assert.AreEqual(product, Item.PRoduct);
            Assert.AreEqual(2, Item.Quantity);


        }
        [TestMethod]
        public void LineItem_TotalItemCost()
        {
            LineItem lineitem = new LineItem(201,  new Product(101, "Milk", 0.5, 100),2);
            Assert.AreEqual(100, lineitem.TotalItemCost());
        }
    }
}
