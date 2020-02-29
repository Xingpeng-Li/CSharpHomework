using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator.");
            //提示用户输入并获取输入
            string getInput;  //getInput用来接收用户输入
            int num1, num2;  //两个操作数
            char op;  //操作符
            int result;  //结果
            try
            {
                getInput = input("Please enter the first number:");  //提示输入第一个数字
                num1 = Int32.Parse(getInput);
                getInput = input("Please enter the operator:");  //提示输入操作符
                op = Char.Parse(getInput);
                getInput = input("Please enter the second number:");  //提示输入第二个数字
                num2 = Int32.Parse(getInput);
                //根据操作符计算结果
                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error:divide by 0!");  //除数为0
                            return;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        Console.WriteLine("Error:invalid operator!");
                        return;
                }
                //输出结果
                Console.WriteLine($"The result is:{result}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error:invalid format!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error:overflow!");
                return;
            }
        }
        /*
         * input函数用于获取用户输入，参数为用户输入提示
         */
        static string input(string tip)
        {
            Console.Write(tip);   //首先打印提示
            string input;
            input = Console.ReadLine();
            return input;
        }
    }
}
