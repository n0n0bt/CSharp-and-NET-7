using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Saturday_29._04.Classes
{
    public class Rectangle : Interfaces.Ipolygon, Interfaces.Icolor
    {
        public int calculateArea(int par, int par1)
        {
            return par * par1;
        }

        public void Color()
        {
            Console.WriteLine("The color is blue!");
        }
    }
}
