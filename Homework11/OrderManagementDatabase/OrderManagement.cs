namespace OrderManagementDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class OrderManagement : DbContext
    {
        public OrderManagement()
            : base("OrderManagement")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderManagement>());
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Goods> GoodsSet { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderTime { get; set; }
        public int CustomerID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        [Required]
        public int GoodsID { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
    }
    public class Goods
    {
        public int GoodsID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}