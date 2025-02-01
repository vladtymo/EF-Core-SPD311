namespace EF_Core_SPD311.Data;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public DateTime? Birthdate { get; set; }
    
    // ---- navigation properties
    public ICollection<Order> Orders { get; set; }
}