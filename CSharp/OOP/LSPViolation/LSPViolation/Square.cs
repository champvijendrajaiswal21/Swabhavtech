using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPViolation
{
    class Square : Rectangle
    {
       
        public Square (int side) : base(side,side)
        {
            
        }
        override public int Height
        {
            set
            {
               base. _height = base._width= value;
            }
            get
            {
                return _height;
            }
        }
        override public int Width
        {
            set
            {
               base._height= base._width = value;
            }
            get
            {
                return _height;
            }
        }

        }
}
