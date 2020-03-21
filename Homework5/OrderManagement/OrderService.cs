using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement
{
    //订单服务类
    class OrderService
    {
        private int orderIDCounter = 0;
        private List<Order> orders;
        public OrderService()
        {
            orders = new List<Order>();
            GoodsDic.AddGoods(1, "Apple", 5);
            GoodsDic.AddGoods(2, "Orange", 3);
            GoodsDic.AddGoods(3, "Banana", 4);
            GoodsDic.AddGoods(4, "Mango", 10);
            GoodsDic.AddGoods(5, "Pear", 6);
            GoodsDic.AddGoods(6, "Lemon", 8);
            GoodsDic.AddGoods(7, "Strawberry", 12);
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
            newOrder.OrderID = ++orderIDCounter;
            orders.Add(newOrder);
            return orderIDCounter;
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
