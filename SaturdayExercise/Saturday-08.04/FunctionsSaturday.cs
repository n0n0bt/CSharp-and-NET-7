using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Saturday_08._04
{

    
    public class FunctionsSaturday
    {   // Write a program in C# Sharp to create a function for the sum of two number
        public static int sumOfTwoNum (int one, int two)
        {
            return one + two;
        }
       // Write a program in C# Sharp to create a function to input a stringand count number of spaces are in the string
        
        public static int numOfSpaces (string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ') { count++; }
            }
            return count;
        }

        // Write a program in C# Sharp to calculate the sum of elements in an array

        public static int CalculateSum (Array arr)
        {
            int sum = 0;

            foreach (int item in arr)
            {
                sum += item;
            }

            return sum;
        }

        // Write a program in C# Sharp to create a function to swap the values of two integer numbers.


        
    }
    public class SwapingValues
    {
        public static int Swap(ref int uno, ref int dos)
        {
            int temp = uno;
            uno = dos;
            dos = temp;
            return temp;
        }
    }

   /* Write a program in C# Sharp to create a function to calculate 
        the result of raising an integer number to another.*/

    public class CalcRaisingNum
    {

        public static int TheCalc (int baseNum, int exponent)
        {
            int res = 1;

            for (int i = 0; i < exponent; i++)
            {
                res *= baseNum;
            }
            return res;
        }
    }

    // Write a program in C# Sharp to create a function to display the nnumber Fibonacci sequence
    public class Fibonacci
    {
        public static int Process (int n)
        {

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Process(n - 1) + Process(n - 2);
            }

        }
       
    }

    // Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

    public class IndividualDigits
    {
        public static int DigitsSum(int nomb)
        {
            int sum = 0;
            string n = Convert.ToString(nomb);

            for (int i = 0; i < n.Length; i++)
            {
                sum += Convert.ToInt32(n.Substring(i, 1));
            }

            return sum;

        }
    }
    // Write a program in C# Sharp to create a recursive function to find the factorial of a given number
    public class RecursiveFunction
    {
        public static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }



}
