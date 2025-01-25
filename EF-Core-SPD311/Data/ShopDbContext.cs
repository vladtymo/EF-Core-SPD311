using Microsoft.EntityFrameworkCore;

namespace EF_Core_SPD311.Data;

public class ShopDbContext : DbContext
{
    public ShopDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            "workstation id=shop-db.mssql.somee.com;packet size=4096;user id=wladnaz_SQLLogin_1;pwd=qsyiy5d3ff;data source=shop-db.mssql.somee.com;persist security info=False;initial catalog=shop-db;TrustServerCertificate=True");
    }

    // -------- tables
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Order> Orders { get; set; }
}

// ------ entities
public class Product
{
    // PrimaryKey = Id,ProductId
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string? Description { get; set; }
    //public string Category { get; set; }
    public int Stock { get; set; }
    public DateTime CreatedAt { get; set; }
    // ForeignKey = EntityNameId
    public int CategoryId { get; set; }
    
    // ---- navigation properties
    public Category Category { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // ---- navigation properties
    public ICollection<Product> Products { get; set; }
}

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Surname { get; set; }
    public string Phone { get; set; }
    public DateTime? Birthdate { get; set; }
    
    // ---- navigation properties
    public ICollection<Order> Orders { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public double TotalPrice { get; set; }
    public int Discount { get; set; }
    public DateTime Date { get; set; }
    public int ClientId { get; set; }
    
    // ---- navigation properties
    public Client Client { get; set; }
}

