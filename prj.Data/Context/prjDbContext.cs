using Microsoft.EntityFrameworkCore;
using prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj.Data.Context
{
    public class prjDbContext : DbContext
    {
        public prjDbContext(DbContextOptions<prjDbContext> options) : base(options) { }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add 10 products with real names and prices

            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Phone" }
           );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "iPhone 12", Price = 999.99m },
                new Product { Id = 2, CategoryId = 1, Name = "Samsung Galaxy S21", Price = 899.99m },
                new Product { Id = 3, CategoryId = 1, Name = "Google Pixel 5", Price = 699.99m },
                new Product { Id = 4, CategoryId = 1, Name = "Sony PlayStation 5", Price = 499.99m },
                new Product { Id = 5, CategoryId = 1, Name = "Xbox Series X", Price = 499.99m },
                new Product { Id = 6, CategoryId = 1, Name = "Nintendo Switch", Price = 299.99m },
                new Product { Id = 7, CategoryId = 1, Name = "Apple AirPods Pro", Price = 249.99m },
                new Product { Id = 8, CategoryId = 1, Name = "Samsung 4K Smart TV", Price = 1499.99m },
                new Product { Id = 9, CategoryId = 1, Name = "Dell XPS 13 Laptop", Price = 1299.99m },
                new Product { Id = 10, CategoryId = 1, Name = "Logitech G502 Gaming Mouse", Price = 79.99m }
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}



