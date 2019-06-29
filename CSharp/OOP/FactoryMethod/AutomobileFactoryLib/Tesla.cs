using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileFactoryLib
{
    class Tesla : IAutomobile 
    {
        public void Start()
        {
            Console.WriteLine("tesla start");
        }
        public void Stop()
        {
            Console.WriteLine("tesla stop");
        }
    }
}
