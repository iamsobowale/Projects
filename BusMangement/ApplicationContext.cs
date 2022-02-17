using BusMangement.Models;
using BusMangement.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BusMangement
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;database=BusManagement;port=3306;password=Pencil_1");
        }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Staff> Staves { get; set; }
        public DbSet<Park> Parks { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<ParkTrip> ParkTrips { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<VehiclePayment> VehiclePayments { get; set; }
    }
}