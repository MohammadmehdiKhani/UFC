using Microsoft.EntityFrameworkCore;
using UFC_API.Models;
using UFC_API.Data.Configurations;

namespace UFC_API.Data;

public class AppDbContext : DbContext
{
    public DbSet<Fighter> Fighters => Set<Fighter>();
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FighterConfiguration());
    }
}