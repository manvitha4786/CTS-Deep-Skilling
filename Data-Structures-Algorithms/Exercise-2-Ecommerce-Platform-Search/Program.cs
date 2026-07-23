using System;

class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    // Linear Search
    static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == targetId)
            {
                return product;
            }
        }
        return null;
    }

    // Binary Search
    static Product BinarySearch(Product[] products, int targetId)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == targetId)
            {
                return products[mid];
            }
            else if (products[mid].ProductId < targetId)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return null;
    }

    static void Main(string[] args)
    {
        // Sorted array of products
        Product[] products =
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Phone", "Electronics"),
            new Product(103, "Shoes", "Fashion"),
            new Product(104, "Watch", "Accessories"),
            new Product(105, "Bag", "Fashion")
        };

        int searchId = 104;

        // Linear Search
        Console.WriteLine("=== Linear Search ===");

        Product result1 = LinearSearch(products, searchId);

        if (result1 != null)
        {
            Console.WriteLine("Product Found!");
            Console.WriteLine("ID: " + result1.ProductId);
            Console.WriteLine("Name: " + result1.ProductName);
            Console.WriteLine("Category: " + result1.Category);
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        Console.WriteLine();

        // Binary Search
        Console.WriteLine("=== Binary Search ===");

        Product result2 = BinarySearch(products, searchId);

        if (result2 != null)
        {
            Console.WriteLine("Product Found!");
            Console.WriteLine("ID: " + result2.ProductId);
            Console.WriteLine("Name: " + result2.ProductName);
            Console.WriteLine("Category: " + result2.Category);
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}