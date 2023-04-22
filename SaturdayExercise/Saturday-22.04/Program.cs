using Saturday_22._04.Methods;

Cat.HowManyCats();

Cat marko = new Cat();

Cat.HowManyCats();

Cat pimpa = new Cat();
Cat.HowManyCats();

Stuff staff1 = new Stuff("Naumche", "Joshevski");

staff1.HoursWorked = 160;

int pay = staff1.CalculatePay();

Console.WriteLine(pay);



Person person1 = new Person("Naumche", "Joshevski");

person1.DateOfBirth = new DateTime(1996, 10, 8);

Console.WriteLine("The full name of the Person is: " + person1.GetFullName() + " The Age of Person is:  " + person1.GetAge());


Answers answers = new Answers();

List<string> list = answers.MyList;

list.Add("Skopje");
list.Add("Belgrad");
list.Add("Zagreb");

foreach (string item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("Whats the capital city of Macedonia?");

if (Console.ReadLine() == list[0])
{

    Console.WriteLine("Yeah! Thats Correct! Go to the next question: ");

} else
{
    Console.WriteLine("Thats not correct!");
}

foreach (string item in list)
{
    Console.WriteLine(item);
}

Console.Write("Whats the capital city of Croatia?");

if (Console.ReadLine() == list[2])
{

    Console.WriteLine("Yeah! Thats Correct! Go to the next question: ");

}
else
{
    Console.WriteLine("Thats not correct!");
}




Document document = new Document("PhoneNumber.txt", 4);
Document document1 = new Document("Report.txt", 6);

document.Present();
document1.Present();




Employee employee = new Employee("Naumche", "Joshevski");
Employee employee1 = new Employee("Naumche", "Joshevski");
Employee employee2 = new Employee("Naumche", "Joshevski");

int random = new Random().Next(1, 999);
//Console.WriteLine(random);

Console.WriteLine("\t" + employee + "\n\t" + employee1 + "\n\t" + employee2);






