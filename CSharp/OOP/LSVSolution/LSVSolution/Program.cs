using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSVSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20, 80);
            Square square = new Square(20);
            Display(rectangle);
            Display(square);
            shouldnotchange_widthwhen_heightchange(rectangle);
            shouldnotchange_widthwhen_heightchange(square);

        }
        private static void  Display(IShape s)
        {
            Console.WriteLine(s.CalculateArea());
        }
        static private void shouldnotchange_widthwhen_heightchange(IShape shape)
        {
            int beforewidth = shape.Width;
            Console.WriteLine(beforewidth);
            shape.Height = 100;
            int afterWidth = shape.Width;
            Console.WriteLine(afterWidth);

            Console.WriteLine(beforewidth == afterWidth);

        }
    }
}
