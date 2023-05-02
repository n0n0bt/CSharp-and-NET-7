using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_29._04.Classes
{
    public class Employee :  Interfaces.IPerson
    {
        public string Name { get; set; }
        public int Save(int id)
        {
            // Save for the event

            return id;
        }
    }
}
