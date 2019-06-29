using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    class Audi:IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Audi starts");
        }
        public void Stop()
        {
            Console.WriteLine("Audi stops");
        }
    }
}
