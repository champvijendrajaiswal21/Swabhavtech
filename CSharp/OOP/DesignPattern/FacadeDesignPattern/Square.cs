using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeDesignPattern
{
   public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine( " inside Square draw()");
        }
    }
}
