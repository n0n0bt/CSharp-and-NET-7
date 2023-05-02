using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_29._04.Classes
{
    public class Person : Interfaces.Iwork, Interfaces.Isleep, Interfaces.Irecreation
    {
        public DateTime Date()
        {
            return DateTime.Now;
        }

        public void Sleep()
        {
            Console.WriteLine("You sleep to much!");
        }

        public int Working(int num)
        {
            return num;
        }
    }
}
