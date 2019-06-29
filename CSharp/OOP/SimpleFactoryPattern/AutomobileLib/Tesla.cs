using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    class Tesla : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("tesla starts");
        }
        public void Stop()
        {
            Console.WriteLine("tesla stops");
        }
    }
}
