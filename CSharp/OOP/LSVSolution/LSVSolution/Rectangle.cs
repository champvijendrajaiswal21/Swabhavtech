using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSVSolution
{
    class Rectangle : IShape
    {
         int _width;
         int _height;

        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;

        }
         public int Height
        {
            set
            {
                _height = value;
            }
            get
            {
                return _height;
            }
        }
        public int Width
        {
            set
            {
                _width = value;
            }
            get
            {
                return _width;
            }
        }
        public int CalculateArea()
        {
            return _width * _height;
        }

    }
}
