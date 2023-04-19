using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Library.Models
{
    public class Student : Person
    {

        public Student(string name, int age) : base(name, age)
        {
            
        }

        public void Study() { Console.WriteLine("I'm studying!"); }

        public string Introduce () { return $"Hi my name is {this.name}. I am a student, and {this.GetAge()} old."; }

        public void ShowAge() { Console.WriteLine($"My age is : {this.GetAge()} years old"); }
    }
}
