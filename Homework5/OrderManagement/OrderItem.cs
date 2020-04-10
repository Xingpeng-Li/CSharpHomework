using System.Collections.Generic;

namespace OrderManagement
{
    //订单明细类
    public class OrderItem
    {
        private Goods thisGoods;
        internal Goods ThisGoods { get => thisGoods; set => thisGoods = value; }

        public int GoodsID { get => thisGoods.GoodsID; }
        public string GoodsName { get => thisGoods.Name; }
        public double GoodsPrice { get => thisGoods.Price; }

        private int quantity;
        public int Quantity { get => quantity; set => quantity = value; }

        public OrderItem(Goods thisGoods, int quantity)
        {
            this.ThisGoods = thisGoods;
            this.Quantity = quantity;
        }

        public OrderItem() { }

        public override string ToString()
        {
            return $"{ThisGoods.GoodsID}".PadRight(5) + "|" +
                $"{ ThisGoods.Name}".PadRight(20) + "|" +
                $"{ThisGoods.Price}".PadRight(10) + "|" +
                $"{Quantity}".PadRight(5);
        }

        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   ThisGoods.GoodsID == item.ThisGoods.GoodsID &&
                   Quantity == Quantity;
        }

        public override int GetHashCode()
        {
            return ThisGoods.GoodsID + Quantity;
        }
    }
}
