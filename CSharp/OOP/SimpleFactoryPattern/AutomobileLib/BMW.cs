using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    class BMW : IAutomobile
    {
      public void Start()
        {
            Console.WriteLine("BMW starts");
        }
    public void Stop()
        {
            Console.WriteLine("BMW stops");
        }
    }
}
