using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqWithEFCore.Models;

namespace LinqWithEFCore.Models;

public class Northwind : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = Path.Combine(Environment.CurrentDirectory, "DataBase" ,"Northwind.db");
        optionsBuilder.UseSqlite($"Filename={path}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if ((Database.ProviderName is not null) && (Database.ProviderName.Contains("Sqlite")))
        {
            modelBuilder.Entity<Product>().Property(product => product.UnitPrice).HasConversion<double>();
        }
    }
}




public class Product
{
    public int ProductId { get; set; }
    [Required]
    [StringLength(40)]
    public string ProductName { get; set; } = null!;
    public int? SupplierId { get; set; }
    public int? CategoryId { get; set; }
    [StringLength(20)]
    public string? QuantityPerUnit { get; set; }
    [Column(TypeName = "money")] // required for SQL Server provider
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public short? UnitsOnOrder { get; set; }
    public short? ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
}


public class Category
{
    public int CategoryId { get; set; }
    [Required]
    [StringLength(15)]
    public string CategoryName { get; set; } = null!;
    public string? Description { get; set; }
}
