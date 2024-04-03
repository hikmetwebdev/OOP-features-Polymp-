using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public class Circle:Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            double area = Math.Round( Math.PI * Radius*Radius);
            return area;
        }
    }
}
