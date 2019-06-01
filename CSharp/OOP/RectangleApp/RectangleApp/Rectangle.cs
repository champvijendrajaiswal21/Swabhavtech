using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleApp
{
    class Rectangle
    {
        public int width;
        public int height;
       
        public int CalculateArea()
        {
            int area;
            area = width * height;
            return area;
        }
    }
}
