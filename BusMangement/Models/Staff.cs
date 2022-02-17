namespace BusMangement.Models
{
    public class Staff : Person
    {
        public int Id { get; set; }
        public string Registration { get; set; }
        public int ParkId { get; set; }
        public Park Park { get; set; }
        
    }
}