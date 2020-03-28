using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class GoodsDic
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

        public static Dictionary<int, GoodItem> GoodsDictionary = new Dictionary<int, GoodItem>
        {
            {1,new GoodItem("Apple",5) },
            {2,new GoodItem("Orange",3) },
            {3,new GoodItem("Banana",4) },
            {4,new GoodItem("Mango",10) },
            {5,new GoodItem("Pear",6) },
            {6,new GoodItem("Lemon",8) },
            {7,new GoodItem("Strawberry",12) }
        };
       
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
