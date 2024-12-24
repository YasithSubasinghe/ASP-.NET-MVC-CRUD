using Microsoft.EntityFrameworkCore;

namespace ServiceStation.Web.Models
{
    public class SeviceDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleService> VehicleServices { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public SeviceDBContext(DbContextOptions<SeviceDBContext>options):base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ServiceStation;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
