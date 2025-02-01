using System.ComponentModel.DataAnnotations;

namespace EF_Core_SPD311.Data;

// Primary entity
public class Order
{
    public int Id { get; set; }
    public double TotalPrice { get; set; }
    public int Discount { get; set; }
    public DateTime Date { get; set; }
    public int ClientId { get; set; }
    public int? DetailId { get; set; }
    
    // ---- navigation properties
    public Client Client { get; set; }
    public OrderDetail Detail { get; set; }
    public ICollection<Product> Products { get; set; }
}
// ------ 1-1
// Related entity
public class OrderDetail
{
    //[Key]
    public int OrderId { get; set; } // Первинний ключ + Зовнішній ключ
    public string ShippingAddress { get; set; } = null!;
    public decimal TotalAmount { get; set; }
    public int Invoice { get; set; }
    
    // Навігаційна властивість
    public Order Order { get; set; } = null!;
}