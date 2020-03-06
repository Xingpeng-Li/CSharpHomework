using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Triangle : Shape
    {
        private double sideA;
        public double SideA
        {
            get => sideA;
        }
        private double sideB;
        public double SideB
        {
            get => sideB;
        }
        private double sideC;
        public double SideC
        {
            get => sideC;
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            CheckLegality();
        }
        public override void CheckLegality()
        {
            double maxSide = Math.Max(Math.Max(sideA, sideB), sideC);
            if (sideA <= 0 || sideB <= 0 || sideC <= 0 || sideA + sideB + sideC - maxSide < maxSide)
            {
                Console.WriteLine("This triangle is illegal!");
                sideA = sideB = sideC = 0.0;
            }
        }

        public override double Area
        {
            get
            {
                double p = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }
        }
    }
}
