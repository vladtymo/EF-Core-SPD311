using EF_Core_SPD311.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core_SPD311.Configurations;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
        builder.Property(x => x.Description)
            .HasMaxLength(3000)
            .IsRequired(false);
        
        builder
            .HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId);

        builder
            .HasMany(x => x.Orders)
            .WithMany(x => x.Products)
            .UsingEntity(
                l => l.HasOne(typeof(Order)).WithMany().HasForeignKey("OrderId"),
                r => r.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductId"));
    }
}