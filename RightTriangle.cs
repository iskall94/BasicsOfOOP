using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfOOP
{
    internal class RightTriangle
    {
        // A private field with height and field
        int _height;
        int _width;
        
        // A constructor with two parameters this time, we need height + width
        public RightTriangle(int height, int width)
        {
            _height = height;
            _width = width;
        }

        // Remaining methods to calculate the triangle's data with .Sqrt and .Pow

        public double GetTriangleHypotenuse()
        {
            return Math.Sqrt(Math.Pow(_height, 2) + Math.Pow(_width, 2));
        }

        public double GetTrianglePerimeter()
        {
            return _height + _width + GetTriangleHypotenuse();
        }
        public double GetTriangleArea()
        {
            return 0.5 * _height * _width;
        }
    }
}