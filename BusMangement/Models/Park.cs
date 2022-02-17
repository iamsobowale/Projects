using System.Collections.Generic;

namespace BusMangement.Models
{
    public class Park
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual List<Driver> Drivers { get; set; } = new List<Driver>();
        public virtual List<Staff> Staves { get; set; } = new List<Staff>();
        public virtual List<ParkTrip> ParkTrips { get; set; } = new List<ParkTrip>();
        public virtual List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}