using System;
using System.Linq;

namespace OrderManagement
{
    //货物
    public class Goods
    {
        private int goodsID;

        public double Price 
        { get => GoodsDic.GoodsDictionary[GoodsID].Price; }
        public int GoodsID { get => goodsID; set => goodsID = value; }
        public string Name 
        { get => GoodsDic.GoodsDictionary[GoodsID].Name; }

        public Goods(int goodsID)
        {
            if(!GoodsDic.GoodsDictionary.Keys.Contains(goodsID))
            {
                throw new ArgumentException("Cannot find this goods!");
            }
            this.GoodsID = goodsID;
        }

        public Goods() { }
    }
}
