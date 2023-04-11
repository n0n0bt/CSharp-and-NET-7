using Packt.Shared;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Person bob = new();
WriteLine (bob.ToString());

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965,12,22);

WriteLine($"{bob.Name} was born on {bob.DateOfBirth:dddd, d MMMM yyyy}");

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};

WriteLine($"{alice.Name} was born on {alice.DateOfBirth:dd MMM yy}");

bob.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine($"{bob.Name}'s favourite wonder is {bob.FavouriteAncientWonder}. Its integer is {(int)bob.FavouriteAncientWonder}");

bob.Children.Add(new() { Name = "Zoe" });
bob.Children.Add(new() { Name = "Moe" });
bob.Children.Add(new() { Name = "Toe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children");

for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}


BankAccount.InterestRate = 0.012M;  // store a shared value

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C}");
