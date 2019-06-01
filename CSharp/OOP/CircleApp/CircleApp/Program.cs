using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleApp
{
    class Program
    {
        public static int count = 0;
        public static void printInfo(Circle c)
        {
            Console.WriteLine("print info");
            Console.WriteLine(c.Radius);
            Console.WriteLine(c.CalculateArea() );
          


        }
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.WriteLine(new Ci
                rcle().CalculateArea());
            printInfo(new Circle());
        }

        private static void CaseStudy1()
        {
            Circle small = new Circle();
            Circle big = new Circle();
            small.Radius = 2.2f;
            big.Radius = 10.25f;
            Console.WriteLine("radius = " + small.Radius);
            Console.WriteLine("area of small circle = " + small.CalculateArea());
            Console.WriteLine("radius = " + big.Radius);
            Console.WriteLine("area of small circle = " + big.CalculateArea());
            Circle temp = small;
            Console.WriteLine("temp radius =" + temp.Radius);
            Console.WriteLine(small.Radius);
            temp.Radius = 1.1f;
            Console.WriteLine(temp.Radius);
            Console.WriteLine(small.Radius);
            count = 0;
            printInfo(small);
            printInfo(big);
            Console.WriteLine(new Circle().CalculateArea());
            

        }
    }
}
