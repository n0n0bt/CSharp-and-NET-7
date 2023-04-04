using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingFunctions
{
    internal class Factorial
    {
        public static int FactorialOf5(int number)
        {
            return number * FactorialOf4(number - 1);
        }

        public static int FactorialOf4(int number)
        {
            return number * FactorialOf3(number - 1);
        }

        public static int FactorialOf3(int number)
        {
            return number * FactorialOf2(number - 1);
        }

        public static int FactorialOf2(int number)
        {
            return number * FactorialOf1(number - 1);
        }

        public static int FactorialOf1(int number)
        {
            return number * FactorialOf0(number - 1);
        }

        public static int FactorialOf0(int number)
        {
            return 1;
        }
    }

}
