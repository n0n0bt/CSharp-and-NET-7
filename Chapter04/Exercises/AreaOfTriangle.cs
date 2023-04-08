using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class AreaOfTriangle
    {
        public static int TheTriangle(int basee, int height)
        {
            int area = (basee * height) / 2;
            return area;

        }
    }

    public static class MinutesToSeconds
    {
        public static int Convert(int minutes)
        {
            int seconds = minutes * 60;



            return seconds;
        }
    }

    public static class LessThan0orEqual
    {
        public static bool Calc(int number)
        {

            bool result;
            if (number <= 0) { result = true; } else { result = false; };

            return result;
        }
    }

    public static class ReturnSomething
    {
        public static string TheReturn(string arg)
        {
            string add = $"something {arg}";

            return add;
        }
    }

    public static class FlipTheBool
    {
        public static bool TheFlip(bool arg)
        {
            bool newBool;
            if (arg == true) { newBool = false; } else { newBool = true; };

            return newBool;
        }
    }

    public static class AreTheNumEqual
    {
        public static bool TheCalc(int num1, int num2)
        {
            bool falseOrTrue;

            if (num1 == num2) { falseOrTrue = true; } else { falseOrTrue = false; };

            return falseOrTrue;
        }

    }

    public static class BasketballPoints
    {
        public static int TheCalc(int three, int two)
        {
            int threePoints = three * 3;
            int twoPoints = two * 2;

            return threePoints + twoPoints;
        }
    }

    public static class ReturnFirstElArr
    {
        public static int TheReturner(int[] arg)
        {
            return arg[0];
        }
    }


    public static class DivisibleByFive
    {
        public static bool IsDivisibleByFive(int number)
        {
            if (number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static class MilkOrCookies
    {
        public static bool When (int year, int month, int day)
        {
            DateTime dateTime = new DateTime(year,month,day);
            bool christmas;
            if(dateTime.Day == 24) { christmas = true; } else { christmas =  false; }
            return christmas;

        }
    }



}
