using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_22._04.Methods
{
    internal class Cat
    {
        // property
        private static int instances = 0;

        // Constructor
        public Cat()
        {
            instances++;
        }

        // Method which shows num. of objects
        public static void HowManyCats()
        {
            Console.WriteLine("{0} cats adopted",
            instances);
        }
    }
}
