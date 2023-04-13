using Packt.Shared;


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

WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest.");


BankAccount gerrierAccount = new();

gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName, arg1: gerrierAccount.Balance * BankAccount.InterestRate);

WriteLine($"{bob.Name} is a {Person.Species}");

WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

Person blankPerson = new();

WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss}" +
    $" on a {blankPerson.Instantiated:dddd}.");

WriteLine($"{bob.Name} of {bob.HomePlanet} was created at {bob.Instantiated:hh:mm:ss} on a {bob.Instantiated:dddd}.");

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");

WriteLine($"{gunny.Name} of {gunny.HomePlanet} was created at {gunny.Instantiated:hh:mm:ss} on a {gunny.Instantiated:dddd}");

bob.WriteToConsole();

WriteLine(bob.GetOrigin());

(string, int) fruit = bob.getFruit();

WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

(string, int) fruit1 = bob.getFruit();
WriteLine($"{fruit1.Item1}, {fruit1.Item2} there are.");

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));

WriteLine(bob.OptionalParameters());