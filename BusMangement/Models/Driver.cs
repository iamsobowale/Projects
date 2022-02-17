using System;
using System.Collections.Generic;

namespace BusMangement.Models
{
    public class Driver : Person

    {
        public int Id { get; set; }
        public string RegNumber { get; set; }
        public string License { get; set; }
        public int ParkId { get; set; }
        public Park Park { get; set; }
        public virtual List<Vehicle> Vehicles { get; set; }=new List<Vehicle>();
    }
}