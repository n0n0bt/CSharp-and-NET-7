// 1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
using System.ComponentModel;
using System.Xml.Linq;

int num = 15;
int num1 = 16;

if (num == num1)
{
    WriteLine("The numbers are equal!");
}else
{
    WriteLine("The numbers are not equal!");

}

// 2.Write a C# Sharp program to check whether a given number is positive or negative.

int number = -2;

if (number >= 0)
{
    WriteLine("The number is positive");
}else
{
    WriteLine("The number is negative");

}

// 3.Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
Write("Enter yout height: ");

string input = ReadLine();
double height;

if(Double.TryParse(input, out height))
{
    WriteLine($"Your height in cm is: {height} meters.");
}else
{
    WriteLine("Invalid input. Please enter a valid number");
}

if (height < 160)
{
    WriteLine("You are a small guy :)");
} else if (height >= 160 && height <= 180 )
{
    WriteLine("You are TAMAM :)");
}else
{
    WriteLine("You are BIGBOY :)");

}

/* 4.Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria: 
- Marks in Maths >= 65
- Marks in Phy >= 55
- Marks in Chem >= 50
- Total in all three subject >=180
or
-Total in Math and Subjects >=140
*/

WriteLine("Enter your marks in Maths: ");
int maths = Convert.ToInt32(ReadLine());

WriteLine("Enter your marks in phys: ");
int phys = Convert.ToInt32(ReadLine());

WriteLine("Enter your marks in chemy: ");
int chemy = Convert.ToInt32(ReadLine());

int total = maths + phys + chemy;

if (maths >= 65 && phys >= 55 && chemy >= 50 && total >=180)
{
    WriteLine("\nCongratulations! You are eligible for admission to the professional course.");
} else if (maths + total >= 140)
{
    WriteLine("\nCongratulations! You are eligible for admission to the professional course.");

} else
{
    WriteLine("\nSorry, you are not eligible for admission to the professional course.");

}

// 5. Write a C# Sharp program to find the sum of first 10 natural numbers.

int sum = 0;

for (int i = 0; i <= 10; i++)
{
    sum += i;
}

WriteLine($"The sum of the first 10 natural numbers is: {sum}");


// 6.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average

int summ = 0;

WriteLine("Enter 10 numbers:");

for (int i = 1; i <= 10; i++)
{
    Console.Write("Number " + i + ": ");
    int numm = Convert.ToInt32(Console.ReadLine());
    summ += numm;
}

double average = (double)summ / 10;

WriteLine($"The sum of the 10 number is: {summ}, and the average number is: {average}");

// 7. With DO While make a program that prints the multiplication table of a number (5) with number from 1 to 10

int one = 5;
int k = 1;
WriteLine($"Multiplicating table of number {one}:");
do
{
    WriteLine($"{one} x {k} = {one * k}");
    k++;

} while (k <=10);
{
    ReadLine();
}

/* 8. Element Equal to the Sum of the Rest.
 * 
 * Write a program that inputs n integers and checks whether among them there 
is a number equal to the sum of all the rest.
If there is such an element, print "Yes" + its value, otherwise – "No" + 
the difference between the largest element and the sum of the rest (by absolute value) */




// 9. Write a program in C# Sharp to store elements in an array and print it

WriteLine("Write some text: ");

string?[] arrays = new[] { ReadLine() };

for (int l = 0; l <arrays.Length; l++)
{
    WriteLine($"These is your input : {arrays[l]}");
}

// 10.Write a program in C# Sharp to find the sum of all elements of the array.

int[] arrays1 = {1,2,3,4,5,6,345,7} ;
int summm = arrays1.Length;

WriteLine($"The sum of all elements is: {summm}");

// 11. Write a program in C# Sharp to counta total number of duplicate elements in an array

int[] arr = { 5, 2, 3, 4, 5, 5, 7, 8 };
int count = 0;

for(int t = 0; t < arr.Length; t++)
{
    for (int y = t + 1; y < arr.Length; y++)
    {
        if (arr[t] == arr[y])
        {
            count++;
            break;
        }
    }
}

WriteLine($"The total number of duplicated number is: {count}");

// 12. Write a program in C# Sharp to find maximum and minimum element in an array

int[] numArr = {1,4,5,34,55,6,77 };
int max = numArr[0];
int min = numArr[0];

for (int t = 1;t < numArr.Length; t++)
{
    if (arr[t] > max)
    {
        max = numArr[t];
    }
    if (arr[t] < min)
    {
        min = numArr[t];
    }
}

WriteLine($"Maximum number in the array is: {max}");
WriteLine($"Minimum number in the array is: {min}");

// 13. Write a C# Sharp program to get the time of day from a given array of date time values

DateTime dt = new DateTime(2023, 04, 01, 19, 56, 20);
string? time = String.Format("{0:t}", dt);

WriteLine($"The time is: {time}");