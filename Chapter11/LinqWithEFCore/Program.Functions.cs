
using LinqWithEFCore.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

partial class Program
{
    static void FilterAndSort()
    {
        SectionTitle("Filter and sort");

        using (Northwind db = new Northwind())
        {
            DbSet<Product> allProducts = db.Products;

            IQueryable<Product> filteredProducts = allProducts.Where(uniteprice => uniteprice.UnitPrice < 10M);

            IQueryable<Product> sortedAndFilteredProducts = filteredProducts.OrderByDescending(product => product.UnitPrice);


            foreach (Product p in sortedAndFilteredProducts)
            {
                WriteLine("{0}: {1} costs {2:$#,##0.00}",
                    p.ProductId, p.ProductName, p.UnitPrice);
            }

            WriteLine(sortedAndFilteredProducts.ToQueryString());
            Console.WriteLine("----------------------------------------");
        }
    }

    static void filterAndSortQuery()
    {
        using (Northwind db = new Northwind())
        {
            IQueryable<Product> products = from product in db.Products 
                                           where product.UnitPrice <10M
                                           orderby product.UnitPrice descending
                                           select product;

            foreach (Product p in products)
            {
                WriteLine("{0}: {1} costs {2:$#,##0.00}",
                    p.ProductId, p.ProductName, p.UnitPrice);
            }
            WriteLine(products.ToQueryString());
        }
    }
}

