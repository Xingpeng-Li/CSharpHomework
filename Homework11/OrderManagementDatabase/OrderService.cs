using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementDatabase
{
    class OrderService
    {
        public OrderService()
        {
            using (var management = new OrderManagement())
            {
                //若无商品（数据库初始化），默认添加商品
                if(management.GoodsSet.ToList().Count == 0)
                {
                    management.GoodsSet.Add(new Goods() { Name = "apple", Price = 6.8 });
                    management.GoodsSet.Add(new Goods() { Name = "bear", Price = 4.8 });
                    management.GoodsSet.Add(new Goods() { Name = "orange", Price = 2.8 });
                    management.GoodsSet.Add(new Goods() { Name = "lemon", Price = 7.8 });
                    management.SaveChanges();
                }
            }
        }
        //添加顾客
        public int AddCustomer(Customer newCustomer)
        {
            if (newCustomer == null)
            {
                throw new ArgumentException("Cannot add an empty customer!");
            }
            using (var management = new OrderManagement())
            {
                management.Customers.Add(newCustomer);
                management.SaveChanges();
            }
            return newCustomer.CustomerID;
        }
        //添加新订单
        public int AddOrder(Order newOrder)
        {
            if (newOrder == null)
            {
                throw new ArgumentException("Cannot add an empty order!");
            }
            using (var management = new OrderManagement())
            {
                management.Orders.Add(newOrder);
                management.SaveChanges();
            }
            return newOrder.OrderID;
        }
        public void DeleteOrder(int orderID)
        {
            using (var management = new OrderManagement())
            {
                var order = management.Orders.Include("OrderItems").FirstOrDefault(o => o.OrderID == orderID);
                if (order != null)
                {
                    management.Orders.Remove(order);
                    management.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Invalid order!");
                }
            }
        }
        //修改订单，alterType为修改项
        //如果要对订单明细进行修改，则还应传入要修改的订单明细号
        public void AlterOrder(int orderID, String alterType, object alterData, int orderItemID = 0)
        {
            using (var management = new OrderManagement())
            {
                var order = management.Orders.Include("OrderItems").FirstOrDefault(o => o.OrderID == orderID);
                if (order != null)
                {
                    switch (alterType)
                    {
                        case "customer": order.CustomerID = IsInt(alterData); break;
                        case "order time": order.OrderTime = IsDateTime(alterData); break;
                        case "add item": order.OrderItems.Add(isOrderItem(alterData)); break;
                        case "delete item": order.OrderItems.Remove(order.OrderItems.FirstOrDefault(
                            i => i.OrderItemID == orderItemID)); break;
                        case "quantity":
                            order.OrderItems.FirstOrDefault(
                                i => i.OrderItemID == orderItemID).Quantity = IsInt(alterData); break;
                        default: throw new ArgumentException("No such operation!");
                    }
                    management.SaveChanges();
                }
            }
        }

        public List<Order> FindOrder(int orderID)
        {
            using (var management = new OrderManagement())
            {
                var query = management.Orders.Include("OrderItems").Where(order => orderID == int.MinValue || order.OrderID == orderID).OrderBy(order => order.OrderID);
                return query.ToList();
            }
        }
        //检查data是否为String类，是则返回该String值，否则抛出异常
        private String IsString(object data)
        {
            if (data is String)
            {
                return (String)data;
            }
            else
            {
                throw new ArgumentException("This is not a String!");
            }
        }
        private int IsInt(object data)
        {
            if (data is int)
            {
                return (int)data;
            }
            else
            {
                throw new ArgumentException("This is not a integer!");
            }
        }
        private DateTime IsDateTime(object data)
        {
            if (data is DateTime)
            {
                return (DateTime)data;
            }
            else
            {
                throw new ArgumentException("This is not a dateTime!");
            }
        }
        private OrderItem isOrderItem(object data)
        {
            {
                if (data is OrderItem)
                {
                    return (OrderItem)data;
                }
                else
                {
                    throw new ArgumentException("This is not an order item!");
                }
            }
        }
    }
}
