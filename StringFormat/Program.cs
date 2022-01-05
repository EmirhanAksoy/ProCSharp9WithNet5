using System;



// Currency
Console.WriteLine("It costs {0:c}", 99);

// Format decimal number
Console.WriteLine("The number is {0:d6}", 12);

// Exponential notation (exponential notation is useful, both to make long numbers more readable, and to make execution possible)
Console.WriteLine("Exponential notation {0:e}", 99999999999999999);
Console.WriteLine("Exponential notation {0:E}", 99999999999999999);

// Fixed point formatting (format for decimal part of the number)
Console.WriteLine("Fixed point formatting {0:f4}", 13.4534f);

// Basic numerical formatting with commas ex: 12.584,42
Console.WriteLine("Basic numerical formatting {0:n}", 9989789778.735365f);

// Hexa decimal formatting 
Console.WriteLine("Hexa decimal formatting {0:x}", 13547);


Console.WriteLine(LoveSomeone("LOKI"));


static string LoveSomeone(string name)
{
    return string.Format("Hey {0}, I love you {0}", name);
}