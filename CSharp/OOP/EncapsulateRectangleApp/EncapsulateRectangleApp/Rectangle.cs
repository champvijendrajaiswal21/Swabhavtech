using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncapsulateRectangleApp
{
    class Rectangle
    {
        private int _width, _height;
        static readonly int MAX_LIMIT=100;
        static readonly int MIN_LIMIT=1;

        public int Validate(int var)
        {
            if (var < MIN_LIMIT)
            {
                return 1;
            }
            else if (var > MAX_LIMIT)
            {
                return 100;
            }
            else
            {
                return var;

            }
        }
        public void SetHeight(int height)
        {
            _height = Validate(height);

        }
        public void SetWidth(int width)
        {
            _width = Validate(width);
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }
        public int calculatearea()
        {
            int area;
            area = _width * _height;
            return area;
        }

    }
}
