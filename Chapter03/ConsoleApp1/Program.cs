﻿using static System.Convert;

int a = 10;
double b = a;
WriteLine(b);

double c = 9.8;

int d = (int)c;
WriteLine(d);

long e = 10;

int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");



double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}");

double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

foreach ( double n in doubles )
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}


foreach ( double n in doubles )
{
    WriteLine(format:
        "Math.Round({0},0, MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value:n ,digits: 0,
        mode: MidpointRounding.AwayFromZero));
}

int number = 12;
WriteLine(number.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object me = new();
WriteLine(me.ToString());

byte[] binaryObj = new byte[128];
Random.Shared.NextBytes(binaryObj);
WriteLine("Binary object as bytes: ");
for (int i = 0; i < binaryObj.Length; i++)
{
    Write($"{binaryObj[i]:X}");
}

WriteLine();

// converte to Base64 string and output as text
string encoded = ToBase64String(binaryObj);
WriteLine($"Binary Object as Base64: {encoded}");

int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1996");
WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

// int count = int.Parse("abc"); // will show error


Write("How many eggs are there?");
string? input = ReadLine(); // or use "12" in notebook

WriteLine(int.TryParse(input, out int count1));

if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input!");
}
