using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_29._04.Classes
{
    public class Outsiders : Interfaces.IPerson
    {
        public string Name { get; set; }
        public int Save(int id)
        {
            // Take the fee before saving it.
            // Save outsider for event
            return id;
        }
    }
}
