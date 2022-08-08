using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
  public class ProjectNameContext : DbContext
  {
    public DbSet<ClassName> ClassNames { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}