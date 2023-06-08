using Microsoft.EntityFrameworkCore;
using Packt.Shared;

partial class Program
{
    static void QueryingCategories()
    {
        using (Northwind db = new Northwind())
        {
            SectionTitle("Categories and how many products they have.");

            // a query to get all categories and their related products
            IQueryable<Category>? categories = db.Categories?
                .Include(c => c.Products);

            if ((categories is null) || (!categories.Any()))
            {
                Fail("No categories found!");
                return;
            }

            foreach (Category category in categories)
            {
                WriteLine($"{category.CategoryName} has {category.Products.Count} products.");
            }
        }
    }

    static void Queryingproducts()
    {
        using (Northwind db = new())
        {
            SectionTitle("Products and how many quantityes are.");

            IQueryable<Product>? products = db.Products?.Include(p => p.Category);

            if ((products is null) || (!products.Any()))
            {
                Fail("No categories found!");
                return;
            }

            foreach (Product product in products)
            {
                WriteLine($"{product.ProductName} is in {product.Category.CategoryName}");
            }

        }
    }
}

