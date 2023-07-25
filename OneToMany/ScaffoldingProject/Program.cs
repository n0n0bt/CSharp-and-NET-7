// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Naumche;
using System;


static void read()
{
    using (NorthwindContext products = new NorthwindContext())
    {
        DbSet<Product> pro = products.Products;

        foreach (Product p in pro)
        {
            Console.WriteLine(p.Price);
        }

    }
}

read();