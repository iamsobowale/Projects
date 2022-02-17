using System.Collections.Generic;

namespace Ewallet
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SellingPrice { get; set; }
        public int CostPrice { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual List<Order> Orders { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}