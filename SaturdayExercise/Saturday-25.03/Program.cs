// 1. Write a c# program to print Hello and your name in a separate line
WriteLine("Hello");
WriteLine("Naumche Joshevski");

////////////////////////////////////////////////////////////////////////////////

// 2. Write a C# program to print the sum of two numbers
int one = 10;
int two = 5;
WriteLine($"The sum of {one} and {two} is {one + two}");

////////////////////////////////////////////////////////////////////////////////

// 3. write a C# program to print the result of dividing two numbers
WriteLine($"{one} divided with {two} is {one / two}");

////////////////////////////////////////////////////////////////////////////////

// 4.Write a C# program to swap two numbers.

int num1 = 5;
int num2 = 10;

int temp;

temp = num1;
num1 = num2;
num2 = temp;
WriteLine($"This is after swapping: {num1}, {num2}, {temp}");

////////////////////////////////////////////////////////////////////////////////

// 5. Write a C# program to print the output of multiplication of three numbers which will be entered by the user.

WriteLine("Enter number 1: ");
int inpNum1 = Convert.ToInt16(ReadLine());
WriteLine("Enter number 2: ");
int inpNum2 = Convert.ToInt16(ReadLine());
WriteLine("Enter number 3: ");
int inpNum3 = Convert.ToInt16(ReadLine());
WriteLine($"The multiplication from {inpNum1}, {inpNum2} and {inpNum3} is {inpNum1 * inpNum2 * inpNum3}");

////////////////////////////////////////////////////////////////////////////////

// 6.Write a C# program to print on screen the output of adding, subtracting, multiplying and dividing
// of two numbers which will be entered by the user.

WriteLine("Enter number 1: ");
double inpNum4 = Convert.ToDouble(ReadLine());
WriteLine("Enter number 2: ");
double inpNum5 = Convert.ToDouble(ReadLine());

WriteLine($"The sum from adding {inpNum4}, {inpNum5} is {inpNum4 + inpNum5}");
WriteLine($"The sum from substracting {inpNum4}, {inpNum5} is {inpNum4 - inpNum5}");
WriteLine($"The sum from multiplying {inpNum4}, {inpNum5} is {inpNum4 * inpNum5}");
WriteLine($"The sum from dividing {inpNum4}, {inpNum5} is {inpNum4 / inpNum5}");

////////////////////////////////////////////////////////////////////////////////

// 7. Write a C# program that takes an age (for example 20) as input and prints something as "You look older than 20.

Write("Write your age: ");
int age = Convert.ToInt16(ReadLine());

if( age == 18 )
{
    WriteLine("You are daaaamn Young son");
} else if (age < 25 & age > 18)
{
    WriteLine($"You look older than {age}");
} else
{
    WriteLine($"You look younger than {age}");
}

////////////////////////////////////////////////////////////////////////////////

// 8. Write a C# program that takes distance and time as input and displays the speed in kilometres per hour and miles per hour

double distance, time, speedKmh, speedMph;

Write("Enter the distance in kilometers: ");
distance = double.Parse(Console.ReadLine());

Write("Enter the time in hours: ");
time = double.Parse(Console.ReadLine());

// Calculate speed in km/h
speedKmh = distance / time;

// Calculate speed in mph
speedMph = speedKmh / 1.609;

WriteLine($"Speed in kilometers per hour: {speedKmh.ToString("F2")} km/h");
WriteLine($"Speed in miles per hour: {speedMph.ToString("F2")} mph");


////////////////////////////////////////////////////////////////////////////////

// 9. Write a C# Sharp program that takes three letters as input and display them in reverse order.
Write("Enter the first letter: ");
char letter1 = char.Parse(Console.ReadLine());

Write("Enter the second letter: ");
char letter2 = char.Parse(Console.ReadLine());

Write("Enter the third letter: ");
char letter3 = char.Parse(Console.ReadLine());

WriteLine($"Reverse order: {letter3} {letter2} {letter1}");

////////////////////////////////////////////////////////////////////////////////

// 10. Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.

double radius, perimeter, area;

Write("Write the radius of the circle: ");

radius = double.Parse(Console.ReadLine());

perimeter = 2*Math.PI*radius;

area = Math.PI * radius * radius;

WriteLine($"Perimeter of the circle is {perimeter.ToString("F2")}");
WriteLine($"Perimeter of the circle is {area.ToString("F2")}");

ReadLine();

////////////////////////////////////////////////////////////////////////////////

// 11.Write a program in C# to find the length of a string

string myString;

Write("Write a string: ");

myString = ReadLine();

int lengthMyString = myString.Length;

WriteLine($"The length from your string '{myString}' is {lengthMyString}");

////////////////////////////////////////////////////////////////////////////////

// 12. Write a program in C# to count the total number of words in a string.

WriteLine("Write a string: ");

string myString1 = ReadLine();

string[] words = myString1.Split(" ");

int wordCount = words.Length;

WriteLine($"The number of words from your string is: {wordCount}");

////////////////////////////////////////////////////////////////////////////////

// 13. Use the string.Concat() method to concatenate two strings

string concatStrings;

WriteLine("Enter first Name:");
string firstString = ReadLine();

WriteLine("Enter second Name:");
string secondString = ReadLine();


concatStrings = String.Concat(firstString," ", secondString);

WriteLine($"This is your concatenatet strings: {concatStrings}");

////////////////////////////////////////////////////////////////////////////////

// 14. set the >= comparison operator to find out if the age(25) is greater than OR equal to the voting age limit, which is set to 18

int age1;
int votingLimit = 18;

Write("Enter your age:");

age1 = Convert.ToInt16(ReadLine());

if (age1 >= votingLimit)
{
    WriteLine("You can enter");
}
else
{
    WriteLine("You cannot access");
}

////////////////////////////////////////////////////////////////////////////////

// 15. converter from celsius  to farenheit

WriteLine("Enter the tempreture in celsius degrees: ");

double celsius = Convert.ToDouble(ReadLine());

double farenheit = celsius * 1.8 + 32;

WriteLine($"That is {farenheit} temperature farenheits.");