using CatalogoAgil.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CatalogoAgil.DataAccess;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.GenerateSeed();
    }
}