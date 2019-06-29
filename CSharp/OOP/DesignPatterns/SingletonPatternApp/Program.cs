using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Case2();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void Case2()
        {
            DataServices data1 = DataServices.GetInstance();
            DataServices data2 = DataServices.GetInstance();
            data1.DoSomething();
            data2.DoSomething();

        }
        //private static void Case1()
        //{
        //    DataServices data1 = new DataServices();
        //    DataServices data2 = new DataServices();
        //    data2.DoSomething();
        //    data1.DoSomething(); 
        //}
    }
}
