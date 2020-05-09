namespace OrderManagementDatabase
{
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}