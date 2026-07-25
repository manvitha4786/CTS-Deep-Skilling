using System;
using System.Threading.Tasks;
using RetailInventory.Data;
using RetailInventory.Models;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            // Create Categories
            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };

            await context.Categories.AddRangeAsync(electronics, groceries);

            // Create Products
            var product1 = new Product
            {
                Name = "Laptop",
                Price = 75000,
                Category = electronics
            };

            var product2 = new Product
            {
                Name = "Rice Bag",
                Price = 1200,
                Category = groceries
            };

            await context.Products.AddRangeAsync(product1, product2);

            // Save Data
            await context.SaveChangesAsync();

            Console.WriteLine("Data inserted successfully!");
        }
    }
}