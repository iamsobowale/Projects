using System.Collections.Generic;

namespace BusMangement.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string StartingPoint { get; set; }
        public string DestinationPoint { get; set; }
        public int Price { get; set; }
        public virtual List<ParkTrip> ParkTrips { get; set; }=new List<ParkTrip>();
    }
}