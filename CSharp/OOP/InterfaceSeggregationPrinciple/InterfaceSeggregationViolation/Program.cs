using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSeggregationViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Manager manager = new Manager();
                Robot robot = new Robot();
                AtTheWorkstation(manager);
                AtTheWorkstation(robot);
                AtTheCafeteria(manager);
                AtTheCafeteria(robot);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void AtTheCafeteria(Iworker worker)
        {
            Console.WriteLine("at the cafeteria");
            worker.StartEat();
            worker.StopEat();
        }
        static void AtTheWorkstation(Iworker worker)
        {
            Console.WriteLine("at the work station");
            worker.StartWork();
            worker.StopWork();
        }
    }
}
