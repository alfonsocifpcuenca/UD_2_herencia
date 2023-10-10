using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}
