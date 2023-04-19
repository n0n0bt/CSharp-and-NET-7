using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Library.Models
{
    public class StudentProfesorTest 
    {
        public void Main()
        {
            // Create a new Person
            Person p = new Person();
            p.Greet();

            // Create a new Student
            Student s = new Student("Annabelle", 24);
            s.SetAge(20);
            s.Greet();
            s.ShowAge();

            // Creating a new Teacher
            Professor prof = new Professor();
            prof.SetAge(30);
            prof.Greet();
            prof.Explain();

        }


    }
}
