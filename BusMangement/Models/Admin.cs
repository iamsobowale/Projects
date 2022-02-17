using BusMangement.Models;

namespace BusMangement.Repositories
{
    public class Admin : Person
    {
        public int Id { get; set; }
        public string Password { get; set; }
    }
}