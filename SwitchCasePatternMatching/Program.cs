using System;


object value = "Loki";


/// <summary>
/// Pattern matching with switch
/// </summary>
switch (value)
{
    case int i:
        Console.WriteLine($"Object value is {i} . Type is {i.GetType()}");
        break;
    case string s:
        Console.WriteLine($"Object value is {s} . Type is {s.GetType()}");
        break;
    case bool b:
        Console.WriteLine($"Object value is {b} . Type is {b.GetType()}");
        break;
    default:
        break;
}



int luckNumber = 8;

/// <summary>
/// Pattern matching 'when' keyword using
/// </summary>
switch (luckNumber)
{
    case int i when i == 0:
        Console.WriteLine($"This is zero.");
        break;
    case int i when i.Equals(8):
        Console.WriteLine($"This is the lucky number !");
        break;
    default:
        break;
}

