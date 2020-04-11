using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement;

namespace OrderManagementWindows
{
    //表格显示Order类
    class OrderTableView
    {
        private int orderID;
        private List<OrderItem> orderItems;
        private DateTime orderTime;
        private double totalPrice;
        private int totalQuantity;
        private String customerName;
        private String customerAddress;

        public int OrderID { get => orderID; set => orderID = value; }
        public List<OrderItem> OrderItems { get => orderItems; set => orderItems = value; }
        public DateTime OrderTime { get => orderTime; set => orderTime = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int TotalQuantity { get => totalQuantity; set => totalQuantity = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }

        public OrderTableView(Order order)
        {
            orderID = order.OrderID;
            orderItems = order.OrderItems;
            orderTime = order.OrderTime;
            totalPrice = order.TotalPrice;
            totalQuantity = order.TotalQuantity;
            customerName = order.Customer.Name;
            customerAddress = order.Customer.Address;
        }

 //       public Order TransToOrder()
 //       {
 //           return new Order(orderID, new Customer(customerName, customerAddress), orderTime, orderItems);
//        }
    }
}
