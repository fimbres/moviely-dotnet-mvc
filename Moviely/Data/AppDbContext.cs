using Microsoft.EntityFrameworkCore;
using Moviely.Models;

namespace Moviely.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MemberShipType> MembershipTypes { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
