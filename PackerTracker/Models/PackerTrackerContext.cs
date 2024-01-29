using Microsoft.EntityFrameworkCore;

namespace PackerTracker.Models
{
public class PackerTrackerContext : DbContext
{
  public DbSet<Item> Items {get; set;}

  public PackerTrackerContext(DbContextOptions options) : base(options) { }
}
}