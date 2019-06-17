using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            shouldnotchange_widthwhen_heightchange(new Rectangle(20,80));
            shouldnotchange_widthwhen_heightchange(new Square(30));

        }
        static private void shouldnotchange_widthwhen_heightchange(Rectangle rectangle)
        {
            int beforewidth = rectangle.Width;
            Console.WriteLine(beforewidth);
            rectangle.Height = 100;
            int afterWidth = rectangle.Width;
            Console.WriteLine( afterWidth);
            
            Console.WriteLine(beforewidth==afterWidth);

        }

    }
}
