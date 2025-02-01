// See https://aka.ms/new-console-template for more information

using System.Configuration;
using EF_Core_SPD311.Data;

Console.WriteLine("Hello EF Core!");

ShopDbContext db = new ShopDbContext();

// --- отримати всі продукти
var products = db.Products.ToList();

foreach (var i in products)
{
    Console.WriteLine($"Product: [{i.Id}] {i.Name} {i.Price}$");
}

// --- додати новий продукт
Console.WriteLine("Enter new product name: ");
string name = Console.ReadLine();

var prod1 = new Product()
{
    Name = name,
    Price = 12.5,
    Description = "Super mega sweet apple!",
    CreatedAt = DateTime.Now,
    CategoryId = 1,
    Stock = 5
};
db.Products.Add(prod1);
db.SaveChanges(); // run SQL commands (insert, update, delete)

Console.WriteLine("Enter product name:");

var product = db.Products.FirstOrDefault(p => p.Name == Console.ReadLine());

if (product != null)
{
    Console.WriteLine($"Found: {product.Name} {product.Price}$");
    db.Products.Remove(product);
    db.SaveChanges();
}
else
    Console.WriteLine("Product not found");
    
var first = db.Products.FirstOrDefault();

if (first != null)
    first.Price += 200;

db.SaveChanges();
