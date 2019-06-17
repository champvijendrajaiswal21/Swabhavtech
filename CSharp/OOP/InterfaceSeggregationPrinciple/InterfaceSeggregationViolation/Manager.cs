using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSeggregationViolation
{
    class Manager : Iworker
    {
       public  void StartWork()
        {
            Console.WriteLine("manager start working");
        }
       public void StopWork()
        {
            Console.WriteLine("manager stop working ");
        }
      public  void StartEat()
        {
            Console.WriteLine("manager start eating");
        }
      public  void StopEat()
        {
            Console.WriteLine("manager stop eating");
        }
    }
}
