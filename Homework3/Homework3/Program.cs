using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] type = { "rectangle", "square", "triangle", "circle" };  //表示可用的形状
            int[] parameterNumbers = { 2, 1, 3, 1 };  //创建对应形状所需要的参数
            Shape shape;
            double sumArea = 0.0;
            for(int i = 0;i < 10;i++)
            {
                int randomType = new Random().Next(0, type.Length);
                double[] parameters = new double[parameterNumbers[randomType]];  //参数
                do
                {
                    for (int j = 0; j < parameters.Length; j++)
                    {
                        Random random = new Random(Guid.NewGuid().GetHashCode());
                        parameters[j] = random.NextDouble() + random.Next(0, 100);
                    }
                    shape = ShapeFactory.Product(type[randomType],parameters);
                } while (shape == null);
                sumArea += shape.Area;
            }
            Console.WriteLine($"The total area is {sumArea}.");
        }
    }
}
