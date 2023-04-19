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
        private int age;

        // Constructor () gives it like Default value
        public Person()
        {
            name = "";
            age = 0;
        }

        // Constructor, but with parametar and exeption
        public Person(string name, int age)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = age;
        }

        
        // Public methods
        public void Greet() { Console.WriteLine("Hello");}

        public void SetAge(int age) { this.age = age; }

        protected int GetAge() { return this.age; }

    }
}
