using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSeggregationSolution
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

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void AtTheCafeteria(IEat worker)
        {
            Console.WriteLine("at the cafeteria");
            worker.StartEat();
            worker.StopEat();
        }
        static void AtTheWorkstation(IWork worker)
        {
            Console.WriteLine("at the work station");
            worker.StartWork();
            worker.StopWork();
        }
    }
}

