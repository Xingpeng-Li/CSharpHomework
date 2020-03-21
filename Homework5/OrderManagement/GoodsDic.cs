using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class GoodsDic
    {
        public class GoodItem
        {
            private String name;
            private double price;

            public GoodItem(string name, double price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get => name; set => name = value; }
            public double Price { get => price; set => price = value; }
        }

        public static Dictionary<int, GoodItem> GoodsDictionary = new Dictionary<int, GoodItem>();
        public static void AddGoods(int ID,String name,double price)
        {
            if (GoodsDictionary.Keys.Contains(ID))
            {
                throw new ArgumentException("The goods alreay exist!");
            }
            GoodsDictionary.Add(ID, new GoodItem(name, price));
        }
        public static void DeleteGoods(int ID)
        {
            if (!GoodsDictionary.Keys.Contains(ID))
            {
                throw new ArgumentException("The goods alreay exist!");
            }
            GoodsDictionary.Remove(ID);
        }
        public static void AlterGoods(int ID,String name,double price)
        {
            if (!GoodsDictionary.Keys.Contains(ID))
            {
                throw new ArgumentException("Cannot find this goods!");
            }
            GoodsDictionary[ID].Name = name;
        }
    }
}
