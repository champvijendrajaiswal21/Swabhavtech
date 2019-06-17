using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           SingleObject object1 = SingleObject.getInstance();

            //show the message
            object1.showMessage();

        }
    }
}
