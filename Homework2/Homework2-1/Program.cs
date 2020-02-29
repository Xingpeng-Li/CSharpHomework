using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//编写程序输出用户指定数据的所有素数因子
namespace Homework2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //首先获取用户指定数据
            UInt32 number = Input();
            PrimeFactors(number);
        }
        static UInt32 Input()
        {
            Console.Write("Please enter a number:");
            String input = Console.ReadLine();
            //将用户输入的数据存成一个数组
            try
            {
                UInt32 number = UInt32.Parse(input);
                return number;
            }
            catch (FormatException)
            {
                Console.Write("Error:Wrong format!");
                return 1;
            }
        }
        static void PrimeFactors(UInt32 number)
        {
            if (number == 1)
            {
                Console.WriteLine("1 have no prime factor.");
                return;
            }
            Console.Write($"All prime factors of {number} :");
            for (UInt32 i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    while (number % i == 0)
                    {
                        number /= i;
                    }
                    Console.Write(i + " ");
                }
            }
            Console.Write(number);
        }
    }
}
