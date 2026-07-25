using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            // Retrieve All Products
            var products = await context.Products.ToListAsync();

            Console.WriteLine("All Products:");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
            }

            // Find Product by ID
            var product = await context.Products.FindAsync(1);

            Console.WriteLine($"\nFound: {product?.Name}");

            // Retrieve First Product with Price > 50000
            var expensive = await context.Products
                .FirstOrDefaultAsync(p => p.Price > 50000);

            Console.WriteLine($"Expensive: {expensive?.Name}");
        }
    }
}