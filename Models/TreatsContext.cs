using Microsoft.EntityFrameworkCore;

namespace PierresTreats.Models
{
    public class TreatsContext : DbContext
    {
        public virtual DbSet<Treat> Treats { get; set; }
        public DbSet<Flavor> Flavors { get; set; }
        public DbSet<TreatFlavor> TreatFlavor { get; set; }

        public TreatsConext(DbContextOptions options) : base(options) { }
    }
}