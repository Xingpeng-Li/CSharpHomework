using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 6, 7, 4, 9, 5, 9, 1 };
            int max, min, sum;
            float average;
            ArrayFunc(array, out max, out min, out average, out sum);
            Console.WriteLine($"Max value:{max}");
            Console.WriteLine($"Min value:{min}");
            Console.WriteLine($"Average:{average}");
            Console.WriteLine($"Sum:{sum}");
        }
        //求一个整数数组的最大值、最小值、平均值和所有数组元素的和
        static void ArrayFunc(int[] array, out int max, out int min, out float average, out int sum)
        {
            //首先给各输出值赋初值
            max = Int32.MinValue;
            min = Int32.MaxValue;
            average = sum = 0;
            if (array.Length == 0)
            {
                Console.WriteLine("Error: empty array!");
                average = max = min = sum = 0;
                return;
            }
            foreach (int data in array)
            {
                if (data > max)
                {
                    max = data;
                }
                if (data < min)
                {
                    min = data;
                }
                sum += data;
            }
            average = (float)sum / array.Length;
        }
    }
}
