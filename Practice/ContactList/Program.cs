using ContactList;
using System.Net;
using System.Threading.Channels;
using System.Xml.Linq;

while (true)
{
    insertPhoneBook();
}


void insertPhoneBook()
{
    Console.WriteLine("Welcome to PhoneBook");

    Console.WriteLine("How many contacts you want to insert?");

    int numContacts = int.Parse(Console.ReadLine());

    PhoneBook phoneBook = new PhoneBook();

    for (int i = 0; i < numContacts; i++)
    {
        Contact contact = new Contact();
        Console.WriteLine("Insert name:");
        contact.Name = Console.ReadLine();

        Console.WriteLine("Insert surname:");
        contact.Surname = Console.ReadLine();

        Console.WriteLine("Insert address:");
        contact.Address = Console.ReadLine();

        Console.WriteLine("How many numbers do you want  to insert?");

        int numberCount = int.Parse(Console.ReadLine());
        List<string> phoneNumbers = new List<string>();
        for (int j = 0; j < numberCount; j++)
        {
            Console.WriteLine($"Insert number{j + 1}");
            phoneNumbers.Add(Console.ReadLine());
        }
        Contact contact1 = new Contact();

        phoneBook.Contacts.Add(contact1);
    }

    phoneBook.ToString();
}