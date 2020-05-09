using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();

            try
            {
                //1号顾客创建一个订单
                int orderID = service.AddOrder(new Order() { CustomerID = 1, OrderTime = DateTime.Now });
                List<Order> orders = service.FindOrder(orderID);
                Console.WriteLine($"订单号：{orderID}，顾客号：{orders[0].CustomerID}，时间：{orders[0].OrderTime}");

                //该订单添加一个订单项
                service.AlterOrder(orderID, "add item", new OrderItem() { GoodsID = 1, OrderID = orderID, Quantity = 20 });
                orders = service.FindOrder(orderID);
                Console.WriteLine($"商品号：{orders[0].OrderItems[0].GoodsID}，数量：{orders[0].OrderItems[0].Quantity}");

                //更改顾客
                service.AlterOrder(orderID, "customer", 2);
                orders = service.FindOrder(orderID);
                Console.WriteLine($"订单号：{orderID}，顾客号：{orders[0].CustomerID}，时间：{orders[0].OrderTime}");

                //删除订单明细
                int orderItemID = orders[0].OrderItems[0].OrderItemID;
                service.AlterOrder(orderID, "delete item", orderItemID);
                orders = service.FindOrder(orderID);

                //删除订单（包括订单明细）
                service.DeleteOrder(orderID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
