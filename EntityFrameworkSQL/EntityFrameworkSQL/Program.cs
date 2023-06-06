// See https://aka.ms/new-console-template for more information
using EntityFrameworkSQL;
using System.Linq;

Console.WriteLine("Hello, World!");


 static void readProduct()
{
    using (var db = new EFContext())
    {
        List<Product> products = db.Products.ToList();
        foreach (Product p in products)
        {
            Console.WriteLine("{0} {1}", p.ID, p.Name);
        }
    }
    return;
}
readProduct();