namespace OrderManagementDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderTime { get; set; }
        public int CustomerID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int TotalQuantity
        {
            get
            {
                int totalQuantity = 0;
                foreach (OrderItem orderItem in OrderItems)
                {
                    totalQuantity += orderItem.Quantity;
                }
                return totalQuantity;
            }
        }
        public double TotalPrice
        {
            get
            {
                double totalPrice = 0;
                foreach (OrderItem orderItem in OrderItems)
                {
                    //获得单个商品的价格
                    double price = 0;
                    using (OrderManagement management = new OrderManagement())
                    {
                        price = management.GoodsSet.FirstOrDefault(g => g.GoodsID == orderItem.GoodsID).Price;
                    }
                    totalPrice += price * orderItem.Quantity;
                }
                return totalPrice;
            }
        }
    }
}