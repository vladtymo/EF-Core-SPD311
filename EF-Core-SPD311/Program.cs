// See https://aka.ms/new-console-template for more information

using System.Configuration;
using EF_Core_SPD311.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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

// ------ створення замовлення з деталями
var client = new Client
{
    Name = "John Doe",
    Surname = "Smith",
    Birthdate = new DateTime(1980, 1, 1),
    Phone = "34-56-23"
};
db.Clients.Add(client);
db.SaveChanges(); // Зберігаємо, щоб отримати ClientId

var order = new Order
{
    TotalPrice = 1225.00,
    Discount = 5,
    Date = DateTime.Now,
    ClientId = client.Id, // Зв’язок з клієнтом
    //Products = new List<Product> { product1, product2 } // Додаємо продукти
};
db.Orders.Add(order);
db.SaveChanges(); // Зберігаємо, щоб отримати OrderId

// Створюємо деталі замовлення (1-1 зв’язок)
var orderDetail = new OrderDetail
{
    OrderId = order.Id, // FK та PK одночасно
    ShippingAddress = "123 Main St",
    TotalAmount = 1225.00m,
    Invoice = 1001 // Номер накладної
};
db.OrderDetails.Add(orderDetail);
db.SaveChanges();

Console.WriteLine("Well done!");

// ------------------- ЗАПУСК STORED PROCEDURE -------------------
db.SetOrderDiscount(2, 75);