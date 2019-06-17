using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSeggregationSolution
{
    class Robot : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("robot start working");
        }
        public void StopWork()
        {
            Console.WriteLine("robot stop working ");
        }
    }
}
