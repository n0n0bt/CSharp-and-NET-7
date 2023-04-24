using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Library.Models
{
    public class Student : Person
    {
        // Constructor that is inherited from the Person class
        public Student(string name, int age) : base(name, age){ }


        public void Study() { Console.WriteLine("I'm studying!"); }

        public string Introduce () { return $"Hi my name is {name}. I am a student, and {GetAge()} old."; }

        public void ShowAge() { Console.WriteLine($"My age is : {GetAge()} years old"); }
    }
}
