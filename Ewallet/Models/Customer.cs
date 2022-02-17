using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ewallet
{
    public class Customer
    {
        [Key()]
        [ForeignKey("Person")]
        public int Personid { get; set; }
        public Person Person { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}