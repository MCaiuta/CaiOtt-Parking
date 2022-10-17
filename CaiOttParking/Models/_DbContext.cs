using Microsoft.EntityFrameworkCore;

namespace CaiOttParking.Models
{
    public class _DbContext: DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Customer> customer { get; set; }
        public DbSet<Vehicle> vehicle { get; set; }
        public DbSet<Car> car { get; set; }
        public DbSet<Motorcycle> motorcycle { get; set; }
        public DbSet<Order> order { get; set; }

    }
}
