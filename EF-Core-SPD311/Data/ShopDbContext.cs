using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_SPD311.Data;

public class ShopDbContext : DbContext
{
    // -------- tables
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Order> Orders { get; set; }

    public ShopDbContext() : base()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        if (!optionsBuilder.IsConfigured)
        {
            var cs = ConfigurationManager.ConnectionStrings["LocalDb"].ConnectionString;
            optionsBuilder.UseSqlServer(cs);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<OrderDetail>().HasKey(x => x.OrderId);
        modelBuilder.Entity<OrderDetail>().Property(ent => ent.OrderId).ValueGeneratedNever();
        modelBuilder.Entity<Order>().HasOne(x => x.Detail)
            .WithOne(x => x.Order)
            .HasForeignKey<Order>(x => x.DetailId);
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShopDbContext).Assembly);
        modelBuilder.SeedData();
    }

    public void SetOrderDiscount(int orderId, int discount)
    {
        Database.ExecuteSqlInterpolated($"EXEC SetOrderDiscount {orderId}, {discount}");
    }
}
