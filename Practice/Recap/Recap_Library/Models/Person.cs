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

        // Constructor ()
        public Person()
        {
            name = "";
            age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = age;
        }

        

        public void Greet() { Console.WriteLine("Hello");}

        public void SetAge(int age) { this.age = age; }

        protected int GetAge() { return this.age; }

    }
}
