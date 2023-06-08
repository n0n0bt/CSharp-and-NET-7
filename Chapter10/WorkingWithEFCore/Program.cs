using Packt.Shared;
using System.Net.Security;

WriteLine("Hallo");

Northwind db = new Northwind();
WriteLine($"Provider:{db.Database.ProviderName}");


SectionTitle("Some Title");

Fail("Failed!");

Info("Infos");

//QueryingCategories();
//Queryingproducts();

//var addResult = AddProduct(6, "Bob's Burgers", 500M);
//var addResult = IncreaseProductPrice("Bob", 20M);

var addResult = DeleteProduct("Bob");


if (addResult == 1)
{
    WriteLine($"Deleted product succesfuly that starts with Bob");
}

ListProducts();