using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSVSolution
{
    class Square : IShape
    {
        int _side;
      public  Square(int side)
        {
            _side = side;
        } 
        public int Width
        {
            set
            {
                _side = value;
            }
            get
            {
                return _side;
            }
        }
        public int Height
        {
            set
            {
                _side = value;
            }
            get
            {
                return _side;
            }
        }
        public int CalculateArea()
        {
            return Height * Width;
        }
    }
}
