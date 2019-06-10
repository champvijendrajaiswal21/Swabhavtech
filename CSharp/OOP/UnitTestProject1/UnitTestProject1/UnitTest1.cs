using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            Student student = new Student();
            String firstName = "Akash";
            String lastName = "Jaiswal";
            String expected = "Akash Jaiswal";
            String result;
            //Act  
            result = student.GetName(firstName, lastName);
            //Assert  
            Assert.AreEqual(expected, result);
        }
    }
}
