using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using ECommerceProject.ECommerceProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace YamanerECommerce.Persistence.Context
{
    public class YamanerECommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YAMANER\\SQLEXPRESS;initial Catalog=Deneme;Integrated Security=True;TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ProductDetail> ProductsDetail { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Season> Seasons { get; set; } // Season'u ekledim 
    }
}
      
    
