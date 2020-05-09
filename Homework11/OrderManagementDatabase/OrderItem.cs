namespace OrderManagementDatabase
{
    using System.ComponentModel.DataAnnotations;

    public class OrderItem
    {
        public int OrderItemID { get; set; }
        [Required]
        public int GoodsID { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
    }
}