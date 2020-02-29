using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lists = Erichsen(2, 100);
            foreach(int data in lists)
            {
                Console.Write(data + " ");
            }
        }
        static List<int> Erichsen(int min,int max)
        {
            List<int> array = new List<int>();
            for (int i = min; i <= max; i++)
            {
                array.Add(i);
            }
            for(int i = 0;i < array.Count;i++)
            {
                for(int j = i + 1;j < array.Count;j++)
                {
                    if(array[j] % array[i] == 0)
                    {
                        array.RemoveAt(j);
                        j--;
                    }
                }
            }
            return array;
        }
    }
}
