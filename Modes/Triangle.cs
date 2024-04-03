using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public class Triangle:Shape
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CalculateArea()
        {
            double area = (a + b + c) / 2;

            return area;
        }
    }
}
