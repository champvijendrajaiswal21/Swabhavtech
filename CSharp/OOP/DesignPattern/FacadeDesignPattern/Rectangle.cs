using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeDesignPattern
{
    class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine(" inside Rectangle draw()");
        }
    }
}
