using System;


// NOTE: Strings are immutable we can't change their value, when we maniplute them we just create new instance with updated value.

string myName = "Emirhan Aksoy";

Console.WriteLine($"Length {myName.Length}");
Console.WriteLine($"CompareTo {myName.CompareTo("Emirhan")}");
Console.WriteLine($"Equals {myName.Equals("Emirhan Aksoyx")}");
Console.WriteLine($"Insert {myName.Insert(myName.Length - 1, "Loki")}");
Console.WriteLine($"PadLeft {myName.PadLeft(2)}");
Console.WriteLine($"PadRight {myName.PadLeft(2)}");
Console.WriteLine($"Trim {myName.Trim()}");
Console.WriteLine($"Upper {myName.ToUpper()}"); 
Console.WriteLine($"Lower {myName.ToLower()}");
Console.WriteLine($"Replace {myName.Replace("a", "x")}");
Console.WriteLine($"Contains {myName.Contains("Emirhan")}");
Console.WriteLine($"Concat {string.Concat("Gökçen"," **-** ","Cesur")}");

// Escape characters 

Console.WriteLine("Single quote \'");
Console.WriteLine("Double quote \" hi there ! :) \"");
Console.WriteLine("Backslash D:\\files\\images ");
Console.WriteLine("Beep \a");
Console.WriteLine("New line \n this is another line !");
Console.WriteLine("Carriage return \r carriage return !");
Console.WriteLine("Insert tab \t insert !");
