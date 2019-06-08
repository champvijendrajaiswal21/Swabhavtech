using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManBoyApp.Constructor.case1
{
    class Child : Parent
    {
        public Child() :base()
        {
            Console.WriteLine("inside child constructor");
        }
    }
}
