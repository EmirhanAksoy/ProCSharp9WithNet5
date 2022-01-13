using System;

/// <summary>
/// Without new keyword 
/// </summary>
string[] cats = { "Lokum", "Borc", "Loki" };


/// <summary>
/// With new keyword 
/// </summary>
string[] cities = new string[] { "İstanbul", "New York" };


/// <summary>
/// With new keyword and size
/// </summary>
string[] avangers = new string[3] { "Dr.Strange", "Spider-Man", "Thor" };


/// <summary>
/// Mismatch size throws complie time error.To check uncomment misMatchSize array
/// </summary>
//int[] misMatchSize = new int[2] { 0, 1 , 2};


/// <summary>
/// Implicitly typed arrays
/// </summary>
var shifts = new string[] { "00.00-12.00", "12.00-24.00" };
var luckNumbers = new int[3] { 1, 4, 8 };




foreach (var shift in shifts)
{
    Console.WriteLine($"Shift : {shift}");
}

