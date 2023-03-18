using FirstConsoleApp.myClass;
namespace HelloDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, DataTypes!");
            int myInt = 256;
            byte myByte = 255; // byte is no more than 255
            bool myBool = false;
            string myString = "Naumche";
            char myChar = 'f';
            DateTime myDateTime = DateTime.Now;

            Console.WriteLine("My int is: " + myInt);
            Console.WriteLine("My byte is: " + myByte);
            Console.WriteLine("My bool is: " + myBool);
            Console.WriteLine("My string is: " + myString);
            Console.WriteLine("My char is: " + myChar);
            Console.WriteLine("The date is: " + myDateTime);

            Class1 myClass = new Class1();

            myClass.ShowMyInt();

        }
    }
}