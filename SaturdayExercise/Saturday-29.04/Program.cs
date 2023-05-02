using Saturday_29._04.Classes;
using Saturday_29._04.Interfaces;

Rectangle rectangle = new Rectangle();

Console.WriteLine(rectangle.calculateArea(12, 34));


Rectangle rectangle1 = new Rectangle();

rectangle1.Color();

Person person = new Person();

Console.WriteLine(person.Working(23));

Console.WriteLine(person.Date());

person.Sleep();


IBankAccount savingAccount = new SavingAccount();
IBankAccount currentAccount = new CurrentAccount();

savingAccount.Deposit(200);
savingAccount.Withdraw(100);
savingAccount.ToString();

currentAccount.Deposit(500);
currentAccount.Withdraw(600);
currentAccount.Withdraw(200);
currentAccount.ToString();

Console.ReadLine();

List<IPerson> personList = new List<IPerson>();

personList.Add(new Guest { Name = "Guest 1" });
personList.Add(new Employee { Name = "Employee 1" });
personList.Add(new Outsiders { Name = "Outsider 1" });

foreach (var per in personList)
{
    per.Save(12);
}