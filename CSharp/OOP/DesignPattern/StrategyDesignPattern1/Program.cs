using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyDesignPattern1;
using LSVSolution;

namespace StrategyDesignPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Rectangle rectangle = new Rectangle(20, 80);
            Square square = new Square(20);
            Display(rectangle);
            Display(square);
        }
        private static void Display(IShape s)
        {
            Console.WriteLine(s.CalculateArea());
        }
    }
}
