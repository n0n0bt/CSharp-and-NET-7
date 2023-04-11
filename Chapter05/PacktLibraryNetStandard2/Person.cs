using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;

public class Person : Object
{

    //Fields

    public string? Name;
    public DateTime DateOfBirth;

    public WondersOfTheAncientWorld FavouriteAncientWonder;

    public List<Person> Children = new List<Person>();
    
}
