using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get => radius;
        }
        private const double PI = 3.14159;

        public Circle(double radius)
        {
            this.radius = radius;
            CheckLegality();
        }
        public override void CheckLegality()
        {
            if (radius <= 0)
            {
                Console.WriteLine("Illegal argument!");
                radius = 0.0;
            }
        }
        public override double Area
        {
            get => PI * radius * radius;
        }
    }
}
