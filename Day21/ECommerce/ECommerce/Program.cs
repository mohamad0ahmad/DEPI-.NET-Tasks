using System;
using System.Linq;
using ECommerce.DbContextFolder;
using ECommerce.Models;

namespace ECommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ECommerceDbContext context = new ECommerceDbContext();

            // Example Data
            var cat = new Category { Name = "Electronics" };
            var prod = new Product { Name = "Laptop", Price = 1500, Category = cat };
            var cust = new Customer { Name = "John Doe", Email = "john@example.com" };
            var order = new Order { OrderDate = DateTime.Now, Customer = cust };
            var od = new OrderDetail { Order = order, Product = prod, Quantity = 2 };

            context.Add(cat);
            context.Add(prod);
            context.Add(cust);
            context.Add(order);
            context.Add(od);
            context.SaveChanges();

            Console.WriteLine("E-Commerce database created and seeded successfully!");
        }
    }
}
