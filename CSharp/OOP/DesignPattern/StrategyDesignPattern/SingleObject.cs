using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyDesignPattern
{
   public class SingleObject
    {
        private static SingleObject instance = new SingleObject();

        private SingleObject() { }

      
        public static SingleObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("single instance created");
        }
    }
}

