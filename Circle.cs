using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfOOP
{
    internal class Circle
    {
        // A private field with radius name.
        int _radius;

        // A constructor with an int radius as a parameter.
        // Every new instances of the circle object must have a radius int as an input.
        public Circle(int radius) 
        {
            _radius = radius;
        }

        // The method to obtain the area of a circle.
        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }

        // A method with the formula for a sphere's volume
        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
        }

        // A method to get the circumference of the circle.
        public double GetCircumference()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
