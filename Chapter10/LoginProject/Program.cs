
// Create Acc

using LoginProject;

/*Console.WriteLine("Enter User Name");
string createUsername = Console.ReadLine();

Console.WriteLine("Enter Password");
string createPassword = Console.ReadLine();

Console.WriteLine("Confirm Password");
string passwordConfirm = Console.ReadLine();
*/

SeedLoginDb seedLoginDb = new SeedLoginDb();
seedLoginDb.Seed();

LoginOrCreateUser.Login();

//LoginOrCreateUser.Create();

