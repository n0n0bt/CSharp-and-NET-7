// 1. What statement can u type in a c# file to discover the compiler and language version?

WriteLine($".NET Core Version: {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");

/////////////////////////////////////////////////////////////////////////////////////////////////////

// 2.What are 2 types of comments in c#?

// This is one

/* This
  is the
  second
 */

/////////////////////////////////////////////////////////////////////////////////////////////////////

// 3. What is difference between a verbatim string and an interpolated string?

string path = @"C:\Users\Privat\Documents\CodeAcademy\code-academy"; // Verbatim string

string name = "John";
int age = 35;
string message = $"My name is {name} and I am {age} years old."; // interpolated string

/////////////////////////////////////////////////////////////////////////////////////////////////////

// 4. Why should you be carefull when using Float and double values?

/* When using floating-point numbers like float and double values in C#,
it's important to be careful because these types are not always precise
due to the way they are stored in memory.
*/

///////////////////////////////////////////////////////////////////////////////////////////////////// 

// 5. How can u determine how many bytes a type like double use in memory?

WriteLine(sizeof(double) + " bytes");

/////////////////////////////////////////////////////////////////////////////////////////////////////

// 6. When should you use the var keyword?

/* You should use the var keyword when the type of the variable is clear and obvious from
the value being assigned to it.

string name = "Naumche";
int age = 27;
-----------------------
var name = "Naumche";
var age = 27;
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////

// 7. What is  the newest syntax to create an instance of a class like xmlDocument?

// XmlDocument doc = new XmlDocument(); EARLIER VERISONS
// XmlDocument doc = new(); NEW VERSION

/////////////////////////////////////////////////////////////////////////////////////////////////////

// 8. Why should you be careful when using the dynamic type?
/*
 * When using the dynamic type in C#, it's important to be careful because it allows 
 * for late binding and type checking at runtime, rather than at compile time. This means
 * that the type of a dynamic variable is not checked by the compiler and can be changed 
 * at runtime, which can lead to potential errors and bugs in the code.
*/

// 9. How do you right-alighn a format string?
string myString = "Hello";
string formattedString = string.Format("{0,10}", myString);
Console.WriteLine(formattedString);