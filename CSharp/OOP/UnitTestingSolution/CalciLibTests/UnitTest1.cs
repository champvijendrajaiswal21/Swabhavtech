using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalciLibTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestofEvenNumbertoCube()
        {
            // arrange
            CalciLib.Calculator calculator = new CalciLib.Calculator();
            int expected = 8;
            int output = 0;
            // act
            output = calculator.CubeofEvenNumber(2);
            // assert
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void NotEvenExceptionTestMethod()
        {
            CalciLib.Calculator calculator = new CalciLib.Calculator();

            string expected = "not an Even Number";
            string message = "";
            // act
            try
            {
                calculator.CubeofEvenNumber(3);
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            // assert
            Assert.AreEqual(expected, message);
        }
        [TestMethod]
        public void NegativeNumberExceptionTestMethod()
        {
            CalciLib.Calculator calculator = new CalciLib.Calculator();

            string expected = "it is negative number";
            string message = "";
            // act
            try
            {
                calculator.CubeofEvenNumber(-1);
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            // assert
            Assert.AreEqual(expected, message);
        }

    }
}

