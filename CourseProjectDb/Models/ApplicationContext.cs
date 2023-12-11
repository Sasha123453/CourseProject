using Microsoft.EntityFrameworkCore;
using CourseProjectDb.Models;
using Microsoft.Extensions.Options;

namespace CourseProjectDb.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Brigade> Brigades { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
