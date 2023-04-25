using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Library.Models
{
    public class Person
    {
        // Fields 
        public string name;
        private int Age;

        // Constructor () gives it like default/start value
        public Person()
        {
            name = "";
            age = 0;
        }

        // Constructor, but with parametar and exeption
        public Person(string name, int age)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.Age = age;
        }

        
        // Public methods
        public void Greet() { Console.WriteLine("Hello");}

        public void SetAge(int age) { this.Age = age; }

        protected int GetAge() { return this.Age; }

    }
}
