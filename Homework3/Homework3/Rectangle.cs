using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Rectangle : Shape
    {
        private double width;
        public double Width
        {
            get => width;
        }
        private double height;
        public double Height
        {
            get => height;
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            CheckLegality();
        }

        public override double Area
        {
            get => width * height;
        }

        public override void CheckLegality()
        {
            if (width <= 0 || height <= 0)
            {
                Console.WriteLine("This rectangle is illegal!");
                width = height = 0.0;
            }
        }
    }
}
