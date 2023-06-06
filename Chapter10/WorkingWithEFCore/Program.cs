using Packt.Shared;
using System.Net.Security;

WriteLine("Hallo");

Northwind db = new Northwind();
WriteLine($"Provider:{db.Database.ProviderName}");
