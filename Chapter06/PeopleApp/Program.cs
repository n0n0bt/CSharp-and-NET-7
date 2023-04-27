using Packt.Shared;
using PacktLibrary;

Person harry = new Person()
{
    Name = "Harry",
    DateOfBirth = new (year:2001, month: 3, day: 25)
};

harry.WriteToConsole();

System.Collections.Hashtable lookupObject = new System.Collections.Hashtable();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;

WriteLine($"Key {key} has value: {lookupObject[key]}");
WriteLine($"Key {harry} has value: {lookupObject[harry]}");

Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;

WriteLine($"Key{key} has value of: {lookupIntString[key]}");

static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person? p = sender as Person;
    if (p is null) return;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}

// another method to handle the Shout event received by the harry object
static void Harry_Shout2(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person? p = sender as Person;
    if (p is null) return;
    WriteLine($"Stop it!");
}

harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout2;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

void OutputPeopleNames(IEnumerable<Person?> people, string title)
{
    WriteLine(title);
    foreach (Person? p in people)
    {
        WriteLine(" {0}",
        p is null ? "<null> Person" : p.Name ?? "<null> Name");
        /* if p is null then output: <null> Person
        else output: p.Name
        unless p.Name is null in which case output: <null> Name */
    }
}
Person?[] people =
{
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" }
};
OutputPeopleNames(people, "Initial list of people:");
Array.Sort(people);
OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");

IPlayable player = new DvdPlayer();
player.Play();

IPlayable cdPlayer = new CdPlayer();
cdPlayer.Play();
cdPlayer.Stop();

List<IPlayable> playables = new List<IPlayable>
{
    cdPlayer,
    player
};

foreach (IPlayable item in playables)
{
    item.Play();
}