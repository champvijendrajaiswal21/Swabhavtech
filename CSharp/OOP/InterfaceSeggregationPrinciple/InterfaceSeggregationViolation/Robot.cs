using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSeggregationViolation
{
    class Robot : Iworker 
    {
        public void StartWork()
        {
            Console.WriteLine("robot start working");
        }
        public void StopWork()
        {
            Console.WriteLine("robot stop working ");
        }
        public void StartEat()
        {
            throw new NotImplementedException();
           
        }
        public void StopEat()
        {
            throw new NotImplementedException();
        }
    }
}
