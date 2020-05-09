namespace OrderManagementDatabase
{
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
}