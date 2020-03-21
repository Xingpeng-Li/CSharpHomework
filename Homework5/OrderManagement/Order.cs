using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    //订单类
    class Order
    {
        private int orderID;
        public int OrderID { get => orderID; set => orderID = value; }

        private Customer customer;
        public Customer Customer { get => customer; set => customer = value; }

        private DateTime orderTime;
        public DateTime OrderTime { get => orderTime; set => orderTime = value; }

        private HashSet<OrderItem> orderItems = new HashSet<OrderItem>();
        public HashSet<OrderItem> OrderItems { get => orderItems; set => orderItems = value; }

        public OrderItem this[int goodsID]
        {
            get
            {
                foreach(OrderItem orderItem in orderItems)
                {
                    if(orderItem.GetHashCode() == goodsID) { return orderItem; }
                }
                throw new ArgumentException("Cannot find such order item!");
            }
        }

        public Order(int orderID, Customer customer, DateTime orderTime, HashSet<OrderItem> orderItems)
        {
            this.OrderID = orderID;
            this.Customer = customer;
            this.OrderTime = orderTime;
            this.OrderItems = orderItems;
        }

        public int TotalQuantity
        {
            get
            {
                int totalQuantity = 0;
                foreach(OrderItem orderItem in OrderItems)
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
                    totalPrice += orderItem.ThisGoods.Price * orderItem.Quantity;
                }
                return totalPrice;
            }
        }

        public override string ToString()
        {
            StringBuilder showString = new StringBuilder($"Order ID:{OrderID}   {Customer}\n");
            showString.Append('-',40);
            showString.AppendLine();
            //使用PadRight实现对齐
            showString.Append("ID".PadRight(5)+"|"+"Name".PadRight(20)+"|"+
                "Price".PadRight(10)+"|"+"Quantity".PadRight(8)+"\n");
            foreach(OrderItem orderItem in OrderItems)
            {
                showString.Append($"{orderItem}\n");
            }
            showString.Append('-', 45);
            showString.AppendLine();
            showString.Append($"Total quantity:{TotalQuantity}    Total price:{TotalPrice}\nOrder time:{OrderTime}\n");
            return showString.ToString();
        }
        public override int GetHashCode()
        {
            return OrderID;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderID == order.OrderID;
        }
    }
}
