using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class ShapeFactory
    {
        public static Shape Product(String type,double[] values)
        {
            Shape shape = null;
            switch (type)
            {
                case "rectangle":
                    if(values.Length != 2)
                    {
                        Console.WriteLine("The parameter length is incorrect!");
                        break;
                    }
                    shape = new Rectangle(values[0], values[1]);
                    break;
                case "square":
                    if (values.Length != 1)
                    {
                        Console.WriteLine("The parameter length is incorrect!");
                        break;
                    }
                    shape = new Square(values[0]);
                    break;
                case "triangle":
                    if (values.Length != 3)
                    {
                        Console.WriteLine("The parameter length is incorrect!");
                        break;
                    }
                    double maxValue = Math.Max(Math.Max(values[0], values[1]), values[2]);
                    if (values[0] + values[1] + values[2] - maxValue < maxValue)
                    {
                        Console.WriteLine("The parameter is incorrect!");
                        break;
                    }
                    shape = new Triangle(values[0], values[1], values[2]);
                    break;
                case "circle":
                    if (values.Length != 1)
                    {
                        Console.WriteLine("The parameter length is incorrect!");
                        break;
                    }
                    shape = new Circle(values[0]);
                    break;
            }
            return shape;
        }
        private static double GetRandomNumber()
        {
            Random random = new Random();
            return random.NextDouble() + (double)random.Next(0, 100);
        }
    }
}
