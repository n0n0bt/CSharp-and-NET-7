using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_22._04.Methods
{
    internal class Employee
    {
        private static int nextAvailableID;
        private string firstName;
        private string lastName;
        private readonly int ID;


        static Employee()
        {
            nextAvailableID = new Random().Next(1, 999);
        }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            nextAvailableID++;
            ID = nextAvailableID;
            

        }

        
        public override string ToString()
        {
            return firstName + " " + lastName + " " + ID;
        }

    }
}
