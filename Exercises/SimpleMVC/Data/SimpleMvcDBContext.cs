using Microsoft.EntityFrameworkCore;
using SimpleMVC.Models;

namespace SimpleMVC.Data
{
    public class SimpleMvcDBContext : DbContext
    {
       


        public SimpleMvcDBContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Card> Cards { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this is fluent API
            modelBuilder.Entity<Card>(entity => 
            {
                entity.Property(e => e.CardID).ValueGeneratedOnAdd();
                entity.HasKey(e => e.CardID);
            });
        }
    }
}
