using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeDesignPattern
{
    class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine(" inside circle draw()");
        }
    }
}
