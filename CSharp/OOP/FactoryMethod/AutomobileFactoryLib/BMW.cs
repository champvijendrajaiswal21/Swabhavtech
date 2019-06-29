using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileFactoryLib
{
    class BMW : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("BWM start");
        }
        public void Stop()
        {
            Console.WriteLine("BWM stop");
        }
    }
}
