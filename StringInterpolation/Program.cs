using System;

string name = "Emirhan Aksoy";

string message = $"My name is {name}";

string messageNameUpper = $"My name is {name.ToUpper()}";

Console.WriteLine(message);

Console.WriteLine(messageNameUpper);

Console.WriteLine("My name is {0}", "Emirhan Aksoy".ToUpper());
