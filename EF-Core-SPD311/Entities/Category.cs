namespace EF_Core_SPD311.Data;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // ---- navigation properties
    public ICollection<Product> Products { get; set; }
}