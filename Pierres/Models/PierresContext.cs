using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pierres.Models
{
  public class PierresContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }
    public DbSet<Patron> Patrons { get; set; }
    public DbSet<Checkout> Checkout { get; set; }

    public PierresContext(DbContextOptions options) : base(options) { }
  }
}