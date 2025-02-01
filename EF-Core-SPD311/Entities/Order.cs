namespace EF_Core_SPD311.Data;

public class Order
{
    public int Id { get; set; }
    public double TotalPrice { get; set; }
    public int Discount { get; set; }
    public DateTime Date { get; set; }
    public int ClientId { get; set; }
    
    // ---- navigation properties
    public Client Client { get; set; }
    public ICollection<Product> Products { get; set; }
}