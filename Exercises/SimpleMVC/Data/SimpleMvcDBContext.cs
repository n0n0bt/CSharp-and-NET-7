using Microsoft.EntityFrameworkCore;
using SimpleMVC.Data.Entities;
using SimpleMVC.Models;

namespace SimpleMVC.Data
{
    public class SimpleMvcDBContext : DbContext
    {
       

        public SimpleMvcDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<User> Users { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this is fluent API

            modelBuilder.Entity<ProductReview>().HasKey(nameof(ProductReview.ProductID), nameof(ProductReview.UserID));
        }
    }
}
