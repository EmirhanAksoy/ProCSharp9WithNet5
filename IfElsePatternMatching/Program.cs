using System;



object name = "Emirhan Aksoy";
object age = 27;

// Can check values and types with 'is' keyword 
Console.WriteLine($"'text' is a System.String value ? : {"text" is string}");
Console.WriteLine($"'text' is not a System.String value ? : {"text" is not string}");
Console.WriteLine($"Is age 27 ? :{age is 27}");
Console.WriteLine($"Is age equal or grater than 27 ? :{age is >= 27}");
// If given object type check is true it sets the variable after type 


/// <summary>
/// If 'name' field is string then value field will be set with name object value 
/// </summary>
/// 

if (name is string value)
    Console.WriteLine(value);


if (name is int number)
    Console.WriteLine(number);


if (age is string ageValue)
    Console.WriteLine(ageValue);


if (age is int ageValueLast)
    Console.WriteLine(ageValueLast);