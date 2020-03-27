using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pierres.Models
{
  public class PierresContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Treats> Treats { get; set; }
    public DbSet<Flavors> Flavors { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Patron> Patrons { get; set; }
    public DbSet<Checkout> Checkout { get; set; }

    public PierresContext(DbContextOptions options) : base(options) { }
  }
}