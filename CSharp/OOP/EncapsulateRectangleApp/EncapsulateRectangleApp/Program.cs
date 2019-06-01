using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncapsulateRectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            small.SetHeight(-5);
            small.SetWidth(10);
            Console.WriteLine(" width = "+ small.GetWidth());
            Console.WriteLine(" height = " + small.GetHeight());
            Console.WriteLine("area of small rectangle = " + small.calculatearea());
            Rectangle big = new Rectangle();
            big.SetHeight(20);
            big.SetWidth(100);
            Console.WriteLine(" width = " + big.GetWidth());
            Console.WriteLine(" height = " + big.GetHeight());
            Console.WriteLine("area of big rectangle = " + big.calculatearea());
        }
    }
}
