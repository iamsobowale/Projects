namespace Ewallet
{
    public class Wallet
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int Pin { get; set; }
        public double Balance { get; set; }
    }
}