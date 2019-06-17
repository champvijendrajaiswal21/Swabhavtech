using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib;

namespace UnitTestShoppingCart
{
    [TestClass]
    public class ProductTestClass
    {
        [TestMethod]
        public void ProductTestCase()
        {
            Product product = new Product(101, "laptop", 0.5, 100000);
            Assert.AreEqual(101, product.ProductId);
            Assert.AreEqual("laptop", product.ProductName);
            Assert.AreEqual(0.5d, product.ProductDiscount);
            Assert.AreEqual(100000d, product.ProductCost);


        }
    }
}
