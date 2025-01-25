// See https://aka.ms/new-console-template for more information

using EF_Core_SPD311.Data;

Console.WriteLine("Hello EF Core!");

ShopDbContext db = new ShopDbContext();

// --- отримати всі продукти
var products = db.Products.ToList();

foreach (var i in products)
{
    Console.WriteLine($"Product: {i.Name} {i.Price}$");
}

// --- додати категорії
db.Categories.AddRange(new Category[]
{
    new() {Name = "Fruits"},
    new() {Name = "Electronics"},
    new() {Name = "Music"},
    new() {Name = "Home & Garden"},
    new() {Name = "Sport"}
});
db.SaveChanges(); // run SQL commands (insert, update, delete)

// --- додати новий продукт
var prod1 = new Product()
{
    Name = "Apple",
    Price = 12.5,
    Description = "Super mega sweet apple!",
    CreatedAt = DateTime.Now,
    CategoryId = 1,
    Stock = 5
};
db.Products.Add(prod1);
db.SaveChanges();