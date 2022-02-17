using System;
using System.Collections.Generic;

namespace BusMangement.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfSeater { get; set; }
        public CarType CarType { get; set; }
        public string RegNumber { get; set; }
        public Driver Driver { get; set; }
        public string DriverId { get; set; }
        public int ParkId { get; set; }
        public Park Park { get; set; }
        public virtual List<VehiclePayment> VehiclePayments { get; set; }= new List<VehiclePayment>();

    }
    
}