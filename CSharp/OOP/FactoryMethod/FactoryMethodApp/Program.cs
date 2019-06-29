using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutomobileFactoryLib;
using System.Reflection;
using System.Configuration;

namespace FactoryMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //IAutomobile auto;
            //TeslaFactory tesla = TeslaFactory.GetInstance();
            //auto = tesla.Make();
            //auto.Start();
            //auto.Stop();

            try
            {
               
                IAutomobile UR = CreateInstance<TeslaFactory>().Make();


                UR.Start();
                UR.Stop();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public static I CreateInstance<I>() where I : class
        {

            string assemblyPath = Environment.CurrentDirectory + "\\AutomobileFactoryLib.dll";

            Assembly assembly;

            assembly = Assembly.LoadFrom(assemblyPath);
            string path = ConfigurationManager.AppSettings["Factory"];
            Type type = assembly.GetType(path);
            var v=  type.GetMethod("GetInstance").Invoke(null, null);
           
            return v as I;

          //  return Activator.CreateInstance(type) as I;


        }
    }
}
