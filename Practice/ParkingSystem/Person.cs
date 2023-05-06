namespace ParkingSystem
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Address { get; set;}

        public Person() { }

        public Person(string id, string name, string surname, int age, string address)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Address = address;
        }
    }


}