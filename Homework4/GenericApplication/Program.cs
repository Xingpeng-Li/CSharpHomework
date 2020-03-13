using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node;
            for(node = head; node != null;node = node.Next)
            {
                action(node.Data);
            }
        }

        //将链表中的元素操作后生成的链表返回
        public GenericList<S> Operate<S>(Func<T,S> func)
        {
            GenericList<S> newList = new GenericList<S>();
            Node<T> node;
            Node<S> newNode;
            for (node = head,newNode = newList.Head; node != null; node = node.Next)
            {
                newList.Add(func(node.Data));
            }
            return newList;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            for (Node<int> node = intlist.Head;
                  node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }

            // 字符串型List
            GenericList<string> strList = new GenericList<string>();
            for (int x = 0; x < 10; x++)
            {
                strList.Add("str" + x);
            }
            for (Node<string> node = strList.Head;
                    node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }

            //打印所有字符
            intlist.ForEach(m => Console.Write(m+ " "));
            Console.WriteLine();

            //求最大值
            int max = int.MinValue;
            intlist.ForEach(m =>
            {
                if (m > max)
                {
                    max = m;
                }
            });
            Console.WriteLine($"最大值是{max}");

            //求最小值
            int min = int.MaxValue;
            intlist.ForEach(m =>
            {
                if (m < min)
                {
                    min = m;
                }
            });
            Console.WriteLine($"最小值是{min}");

            //求和
            int sum = 0;
            intlist.ForEach(m => sum += m);
            Console.WriteLine($"和是{sum}");

            //把链表中所有数据乘2输出
            GenericList<int> doubleList = intlist.Operate(m =>
            {
                return 2 * m;
            });
            doubleList.ForEach(m => Console.Write(m + " "));
            Console.WriteLine();

            //求平方根
            GenericList<double> sqrtList = intlist.Operate(m =>
            {
                return Math.Sqrt(m);
            });
            sqrtList.ForEach(m => Console.Write(m + " "));
            Console.WriteLine();
        }

    }
}