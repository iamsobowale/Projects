using System;

namespace Ewallet
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Person Person { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}