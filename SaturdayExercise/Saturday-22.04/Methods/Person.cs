using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_22._04.Methods
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

      
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        public Person(string firstName, string lastName)
        {

            this.FirstName = firstName;
            this.LastName = lastName;
        }


    }
}
