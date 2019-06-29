using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileFactoryLib
{
    class Audi : IAutomobile 
    {
        public void Start()
        {
            Console.WriteLine("Audi start");
        }
        public void Stop()
        {
            Console.WriteLine("Audi stop");
        }
    }
}
