﻿using SelectionStatements;

string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters");
} else
{
    WriteLine("Your password is strong.");

}


object o = 3;

int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}



int number = Random.Shared.Next(1, 7);
WriteLine($"My random number is {number}");

switch(number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        WriteLine("Three of four");
        goto case 1;
    case 5:
        goto A_label;      
    default:
        WriteLine("Default");
        break;
}

WriteLine("After end of ");

A_label:
WriteLine($"After A_label");


//////////////////////////////////////////////////////////////////////////////////////////////


Animal?[] animals = new Animal?[]
{
    new Cat {Name = "Karen", Born = new(year: 2022, month: 8, day: 23), Legs = 4, IsDomestic = true},
    null,
    new Cat {Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12)},
    new Spider {Name = "Sid Vicious", Born = DateTime.Today, IsPoisonous = true},
    new Spider {Name = "Captain Furry", Born = DateTime.Today}
};

foreach (Animal? animal in animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"The cat named {fourLeggedCat.Name} has 4 legs.";
            break;

        case Cat wildCat when wildCat.IsDomestic == false:
            message = $"The non-domestic cat is named {wildCat.Name}.";
            break;

        case Cat cat:
            message = $"The cat is named {cat.Name}.";
            break;

        default:
            message = $"The animal named {animal.Name} is a {animal.GetType().Name}.";
            break;

        case Spider spider when spider.IsPoisonous:
            message = $"The {spider.Name} spider is poisonous. RUN!";
            break;

        case null:
            message = "The animal is null.";
            break;
    }

    WriteLine($"switch expression: {message}");


    // short version of switch statement

    message = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4
          => $"The cat named {fourLeggedCat.Name} has 4 legs.",
        Cat wildCat when wildCat.IsDomestic == false
          => $"The non-domestic cat is named {wildCat.Name}.",
        Cat cat
          => $"The cat is named {cat.Name}.",
        Spider spider when spider.IsPoisonous
          => $"The {spider.Name} spider is poisonous. RUN!",
        null
          => "The animal is null.",
        _
          => $"The animal named {animal.Name} is a {animal.GetType().Name}."
    };
    WriteLine($"switch expression: {message}");
    
}

