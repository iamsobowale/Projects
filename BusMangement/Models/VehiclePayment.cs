using System;
using Microsoft.EntityFrameworkCore.Design;

namespace BusMangement.Models
{
    public class VehiclePayment
    {
        public int id { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime ExpiringDate { get; set; }
        public string VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int payment { get; set; }
    }
}