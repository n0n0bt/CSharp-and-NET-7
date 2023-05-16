using System.Xml.Serialization;
using Packt.Shared;
using static System.Environment;
using static System.IO.Path;
using Newtonsoft;
using Newtonsoft.Json;

List<Person> people = new()
{
    // elements
    new Person(30000M)
    {
        FirstName = "Alice",
        LastName = "Smith", 
        DateOfBirth = new DateTime(1996, 08, 10)
    },

    new Person(40000M)
    {
        FirstName = "Bob",
        LastName = "Johns",
        DateOfBirth = new DateTime(1991, 11, 23)
    },

    new Person(20000M)
    {
        FirstName = "Charlie",
        LastName = "Chaplin",
        DateOfBirth = new DateTime(1988, 01, 12),

        Children = new HashSet<Person>()
        {
            new Person(0M)
            {
                FirstName = "Sally",
                LastName = "Cox",
                DateOfBirth = new DateTime(1999, 08, 20)
            }
        }
    }
};

// create object that will format a List of person as XML
XmlSerializer xs  = new XmlSerializer(typeof(List<Person>));

// create a file to write to
string path = Path.Combine(Environment.CurrentDirectory, "people.xml");

using (FileStream stream = File.Create(path))
{
    // serialize the object graph to stream
    xs.Serialize(stream, people);
}

WriteLine($"Written {new FileInfo(path).Length} in {path}");
WriteLine("----------------------------------------------");

string[] lines = File.ReadAllLines(path);

foreach (string line in lines)
{
    Console.WriteLine(line);
}


WriteLine();
WriteLine("Deserializing XML");

using (FileStream xmlLoad = File.Open(path, FileMode.Open))
{
    List<Person>? loadedPeople = xs.Deserialize(xmlLoad) as List<Person>;

    if (loadedPeople != null)
    {
        foreach (Person person in loadedPeople)
        {
            WriteLine($"{person.LastName} has {person.Children.Count} children.");
        }
    }
    
}

WriteLine("Working with serialization with JSON format");

string pathh = Combine(CurrentDirectory, "people.json");

using (StreamWriter streamJson = File.CreateText(pathh))
{
    JsonSerializer jss = new JsonSerializer();

    string json = JsonConvert.SerializeObject(people,Formatting.Indented);
    streamJson.Write(json);
    //jss.Serialize(streamJson, people);
}

WriteLine($"Written {new FileInfo(pathh).Length} in {pathh}");
WriteLine("----------------------------------------------");
WriteLine(File.ReadAllText(pathh));

////////////////////////////////////////////////////////////////////
///
WriteLine();
WriteLine("* Deserializing JSON files");

string jsonText = File.ReadAllText(pathh);
List<Person>? jsonPeople = JsonConvert.DeserializeObject<List<Person>>(jsonText);

if (jsonPeople != null)
{
    foreach (Person person in jsonPeople)
    {
        int childrenCount = person.Children != null ? person.Children.Count : 0;
        WriteLine($"{person.FirstName} has {childrenCount} children");
    }
}