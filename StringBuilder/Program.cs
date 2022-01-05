using System;
using System.Text;

// With capacity contructor, if text overflow this capacity string builder create new instance in garbarge-collected managed heap
StringBuilder stringBuilder = new StringBuilder(55);

stringBuilder.Append("Hello there !");

stringBuilder.AppendLine("My name is Emirhan Aksoy");

stringBuilder.AppendLine("How you doin'?");

Console.WriteLine($"Result : {stringBuilder.ToString()}");
Console.WriteLine($"String buidler length : {stringBuilder.Length}");

// Default capacity is 16 char
StringBuilder overFlow = new StringBuilder();

overFlow.AppendLine("With capacity contructor, if text overflow this capacity string builder create new instance in garbarge-collected managed heap");


