using System.ComponentModel.DataAnnotations;

namespace EF_Core_SPD311.Data;

public class Product
{
    // PrimaryKey = Id,ProductId
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    public double Price { get; set; }
    public string? Description { get; set; }
    [MaxLength(100)]
    public string? Manufacture { get; set; }
    public int Stock { get; set; }
    public DateTime CreatedAt { get; set; }
    // ForeignKey = EntityNameId
    public int CategoryId { get; set; }
    
    // ---- navigation properties
    public Category Category { get; set; }
    public ICollection<Order> Orders { get; set; }
}