//2.Create a Class called Products with Productid, Product Name, Price. 
//    Accept 10 Products, sort them based on the price, and 
//    display the sorted Products


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codetest2
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

    class question2
    {
        static void Main()
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numProducts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numProducts; i++)
            {
                Console.WriteLine($"\nEnter details for product {i + 1}:");
                Console.Write("Product ID: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                products.Add(new Product { ProductId = productId, ProductName = productName, Price = price });
            }
            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));//sorting done based on price
            Console.WriteLine("\nSorted Products:");//displaying the products
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: ${product.Price}");
            }
            Console.Read();
        }
    }
}
