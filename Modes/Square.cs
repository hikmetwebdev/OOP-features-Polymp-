using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public class Square:Shape
    {
        public double Side;

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            double area = Side * Side;

            return area;
        }
    }
}
