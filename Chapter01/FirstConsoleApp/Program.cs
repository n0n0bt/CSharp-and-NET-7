using FirstConsoleApp.myClass;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = Console.ReadLine();
            Console.Write("My name is " + myName);

            Class1 myClass = new Class1();
   

        }
    }
}