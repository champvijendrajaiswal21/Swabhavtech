using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutomobileLib;

namespace AutoFactorypatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            AutomobileFactory factory = AutomobileFactory.GetInstance();
            IAutomobile auto1 = factory.Make(AutoType.AUDI);
               Console.WriteLine(auto1.GetType());
               auto1.Start();

            auto1.Stop();
        }

        //private static void Case1()
        //{
        //    AutomobileFactory factory = new AutomobileFactory();
        //    IAutomobile auto1 = factory.Make(AutoType.AUDI);
        //    Console.WriteLine(auto1.GetType());
        //    auto1.Start();
        //    auto1.Stop();
        //    IAutomobile auto2 = factory.Make(AutoType.BMW);
        //    auto2.Start();
        //    auto2.Stop();
        //    IAutomobile auto3 = factory.Make(AutoType.TESLA);
        //    auto3.Start();
        //    auto3.Stop();
        //}
    }
}
