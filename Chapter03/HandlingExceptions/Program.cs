﻿WriteLine("Before parsing");
Write("What is your age? ");


string? input = ReadLine();


try
{
    int age = int.Parse(input!);// (!) is to disable the compailer warning
    WriteLine($"You are {age} old.");
}
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but it is eihter too big or small.");
}
catch (FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After parsing");

