using Microsoft.EntityFrameworkCore;

namespace EF_Core_SPD311.Data;

public static class Extensions
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        // ----- початкова ініціалізація бази даних
        modelBuilder.Entity<Category>().HasData(new Category[]
        {
            new() { Id = 1, Name = "Fruits" },
            new() { Id = 2, Name = "Electronics" },
            new() { Id = 3, Name = "Music" },
            new() { Id = 4, Name = "Home & Garden" },
            new() { Id = 5, Name = "Sport" }
        });
    }
}