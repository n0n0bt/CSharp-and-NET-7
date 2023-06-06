using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSQL
{
    public class EFContext : DbContext
    {
        private const string connectionString = "Server=LAPTOP-0NN1APGK;Database=EFCore22;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Product> Products { get; set; }
    }
}
