namespace BusMangement.Models
{
    public class ParkTrip
    {
        public int Id { get; set; }
        public int ParkId { get; set; }
        public Park Park { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        
    }
}