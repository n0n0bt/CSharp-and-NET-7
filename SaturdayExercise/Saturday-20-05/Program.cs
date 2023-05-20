using Newtonsoft.Json;
using Saturday_20_05;
using System;
using System.Xml.Serialization;
using System.Text.Json;

List<Employee> employees = new List<Employee>()
{
    new Employee()
    {
        Id = 1, Name = "Naumche", Adress = "ScharnhorstStrasse", Subordinared = new List<Employee>()
        {
            new Employee()
            {
                Id = 3, Name = "John", Adress = "Portastr"
            }
        }
    },

     new Employee()
    {
        Id = 2, Name = "Todor", Adress = "Mullerstrasse", Subordinared = new List<Employee>()
        {
            new Employee()
            {
                Id = 4, Name = "Willy", Adress = "Kozara"
            }
        }
    }
};


XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));


using (TextWriter writer = new StreamWriter(@"C:\Users\Privat\Documents\CodeAcademy\code-academy\CSharp-and-NET-7\SaturdayExercise\Saturday-20-05\examp.xml"))
{
    xmlSerializer.Serialize(writer, employees);
}


using (FileStream fileStream = new FileStream(@"C:\Users\Privat\Documents\CodeAcademy\code-academy\CSharp-and-NET-7\SaturdayExercise\Saturday-20-05\examp.xml", FileMode.Open))
{
    List<Employee> deserializedEmployees = (List<Employee>)xmlSerializer.Deserialize(fileStream);



    foreach (Employee employee in deserializedEmployees)
    {
        Console.WriteLine($"Name: {employee.Name}");


        if (employee.Subordinared != null && employee.Subordinared.Count > 0)
        {
            Console.WriteLine("Subordinates:");

            // Iterate over the subordinates and print their names
            foreach (Employee subordinate in employee.Subordinared)
            {
                Console.WriteLine(subordinate.Name);
            }
        }
    }
   
}


string json = JsonConvert.SerializeObject(employees);
Console.WriteLine(json);


Account account = new Account
{
    Email = "james@example.com",
    Active = true,
    CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0,
DateTimeKind.Utc),
    Roles = new List<string>
    {
        "User",
        "Admin"
    }
};




string json1 = JsonConvert.SerializeObject(account, Formatting.Indented);
Console.WriteLine(json1);



