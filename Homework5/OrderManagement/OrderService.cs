using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderManagement
{
    //订单服务类
    public class OrderService
    {
        private int orderIDCounter = 0;

        private List<Order> orders;
        public List<Order> Orders
        {
            get => orders;
            set => orders = value;
        }
        public int OrderIDCounter { get => orderIDCounter; set => orderIDCounter = value; }

        public OrderService()
        {
            orders = new List<Order>();
        }
        public int AddOrder(Order newOrder)
        {
            if(newOrder == null)
            {
                throw new ArgumentException("Cannot add a empty order!");
            }
            foreach(Order order in orders)
            {
                if (order.Equals(newOrder))
                {
                    throw new ArgumentException("Cannot add duplicate order!");
                }
            }
            newOrder.OrderID = ++OrderIDCounter;
            orders.Add(newOrder);
            return OrderIDCounter;
        }
        public void DeleteOrder(int orderID)
        {
            foreach (Order order in orders)
            {
                if (order.OrderID == orderID)
                {
                    orders.Remove(order);
                    return;
                }
            }
            throw new ArgumentException("Invalid order!");
        }
        //修改订单，alterType为修改项
        //如果要对订单明细进行修改，则还应传入要修改的商品号
        public void AlterOrder(int orderID,String alterType,object alterData,int goodsID = 0)
        {
            Order alterOrder = null;
            foreach (Order order in orders)
            {
                if (order.OrderID == orderID)
                {
                    alterOrder = order;
                    break;
                }
            }
            if(alterOrder == null)
            {
                throw new ArgumentException("Invalid order!");
            }
            switch(alterType)
            {
                case "customer name": alterOrder.Customer.Name = IsString(alterData); break;
                case "customer address": alterOrder.Customer.Address = IsString(alterData); break;
                case "order time": alterOrder.OrderTime = IsDateTime(alterData); break;
                case "add item": alterOrder.OrderItems.Add(isOrderItem(alterData)); break;
                case "delete item": alterOrder.OrderItems.Remove(alterOrder[goodsID]); break;
                case "quantity": alterOrder[goodsID].Quantity = IsInt(alterData); break;
                default: throw new ArgumentException("No such operation!");
            }
        }
        
        //根据三个属性查找订单，如果某一个属性不成为查找的条件，则将其置为MinValue或null
        public List<Order> FindOrder(int orderID,String goodsName,String customerName)
        {
            //
            var result = orders.Where(order => orderID == int.MinValue || order.OrderID == orderID)
                .Where(order =>
                {
                    if (goodsName == null)
                    {
                        return true;
                    }
                    //查找这个订单中有没有符合商品名称条件的订单项
                    foreach (OrderItem item in order.OrderItems)
                    {
                        if (item.ThisGoods.Name == goodsName)
                        {
                            return true;
                        }
                    }
                    return false;
                }).Where(order => customerName == null || order.Customer.Name == customerName)
                .OrderBy(order => order.TotalPrice);
            return result.ToList();
        }

        public void Sort(Comparison<Order> comparison = null)
        {
            //默认按照订单号排序
            if(comparison == null)
            {
                orders.Sort((order1, order2) => order1.OrderID - order2.OrderID);
            }
            //自定义排序
            else
            {
                orders.Sort(comparison);
            }
        }

        public void Export(String path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite)) { }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        public void Import(String path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
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
