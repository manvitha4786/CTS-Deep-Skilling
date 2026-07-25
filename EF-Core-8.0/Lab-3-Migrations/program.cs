using System;
using RetailInventory.Data;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new AppDbContext();

            Console.WriteLine("Retail Inventory Database Migration Demo");

            Console.WriteLine("Database Context Created Successfully!");
        }
    }
}