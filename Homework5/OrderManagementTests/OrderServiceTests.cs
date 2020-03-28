using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace OrderManagement.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService service;
        [TestInitialize]
        public void Init()
        {
            service = new OrderService();
        }

        //构造函数->初始化orders
        [TestMethod()]
        public void OrderServiceTest()
        {
            Assert.IsNotNull(service.Orders);
        }

        //传入null->抛出异常
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AddOrderTest1()
        {
            service.AddOrder(null);
        }

        //添加订单->按顺序递增订单号
        [TestMethod()]
        public void AddOrderTest2()
        {
            service.AddOrder(new Order());
            Assert.IsNotNull(service.Orders[0]);
            Assert.AreEqual(1, service.Orders[0].OrderID);
            service.AddOrder(new Order());
            Assert.IsNotNull(service.Orders[1]);
            Assert.AreEqual(2, service.Orders[1].OrderID);
        }

        //删除订单
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DeleteOrderTest1()
        {
            AddOrderTest2();
            service.DeleteOrder(1);
            Assert.IsNotNull(service.Orders[0]);
            Assert.AreEqual(2, service.Orders[0].OrderID);
            _ = service.Orders[1];
        }

        //订单号无效->抛出异常
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteOrderTest2()
        {
            AddOrderTest2();
            service.DeleteOrder(3);
        }

        //无效订单号->抛出异常
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AlterOrderTest1()
        {
            service.AddOrder(new Order(0, new Customer("Mary", "King Street"), DateTime.Now, null));
            service.AlterOrder(3, "customer name", "Jack");
        }

        //无效操作->抛出异常
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AlterOrderTest2()
        {
            service.AddOrder(new Order(0, new Customer("Mary", "King Street"), DateTime.Now, null));
            service.AlterOrder(1, "customer Name", "Jack");
        }

        //成功修改订单
        [TestMethod()]
        public void AlterOrderTest3()
        {
            service.AddOrder(new Order(0, new Customer("Mary", "King Street"), DateTime.Now, new HashSet<OrderItem>()));
            service.AlterOrder(1, "customer name", "Jack");
            Assert.AreEqual("Jack", service.Orders[0].Customer.Name);
            service.AlterOrder(1, "customer address", "Queen Street");
            Assert.AreEqual("Queen Street", service.Orders[0].Customer.Address);
            service.AlterOrder(1, "order time", new DateTime(2020, 3, 28, 12, 0, 0));
            Assert.AreEqual(new DateTime(2020, 3, 28, 12, 0, 0), service.Orders[0].OrderTime);
            service.AlterOrder(1, "add item", new OrderItem(new Goods(3), 20));
            Assert.IsTrue(service.Orders[0].OrderItems.Contains(new OrderItem(new Goods(3), 20)));
            service.AlterOrder(1, "delete item", null, 3);
            Assert.IsFalse(service.Orders[0].OrderItems.Contains(new OrderItem(new Goods(3), 20)));
        }

        [TestMethod()]
        public void FindOrderTest()
        {
            Assert.AreEqual(0, service.FindOrder(int.MinValue, null, null).Count);
            service.AddOrder(new Order(0, new Customer("Mary", "King Street"), DateTime.Now, 
                new HashSet<OrderItem> { { new OrderItem(new Goods(3), 20) } }));
            Assert.AreEqual(new Order(1, new Customer("Mary", "King Street"), DateTime.Now, new HashSet<OrderItem> { { new OrderItem(new Goods(3), 20) } }),
                service.FindOrder(1, null, null)[0]);
            Assert.AreEqual(new Order(1, new Customer("Mary", "King Street"), DateTime.Now, new HashSet<OrderItem> { { new OrderItem(new Goods(3), 20) } }),
                service.FindOrder(int.MinValue, "Banana", null)[0]);
            Assert.AreEqual(new Order(1, new Customer("Mary", "King Street"), DateTime.Now, new HashSet<OrderItem> { { new OrderItem(new Goods(3), 20) } }),
                service.FindOrder(int.MinValue, null, "Mary")[0]);
        }
    }
}