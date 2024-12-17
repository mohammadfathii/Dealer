namespace Dealer.Data;

using Dealer.Models;
using Microsoft.EntityFrameworkCore;

public class DealerDbContext : DbContext
{
    public DealerDbContext(DbContextOptions<DealerDbContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Dealer> Dealers { get; set; }
    public DbSet<City> Cities { get; set; }
}

