using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

"Optional Parameters".DumpAsTitle();


/// <summary>
/// No need to specify for optional parameters
/// If we did not pass value for them they will get default value which assigned in parameter
/// The important thing is default values must be known in the compile time
/// Not able to use DateTime.Now or new Random().Next(1,10) beacuse they will resolved at runtime not compile time
/// </summary>
static void PrintEmail(string from,string to,string subject = "" ,string content = "Empty")
{
    $"FROM : {from}".Dump();
    $"TO : {to}".Dump();
    $"SUBJECT : {subject}".Dump();
    $"CONTENT : {content}".Dump();

    ConsoleHelper.Seperate();
}

PrintEmail("Me", "Loki", "Cuteness", "You are so cute");
PrintEmail("Loki", "Me", "Meow", "Meowwww !!");
PrintEmail("Me", "Loki", "Love");
PrintEmail("Loki", "Me");

/// <summary>
/// Values must be compile-time constant
/// Unccoment the method to check error
/// </summary>
//static void WasHere(string name,DateTime date = DateTime.Now)
//{

//}

ConsoleHelper.Frame("IMPORTANT NOTE : To avoid ambiguity," +
    " optional parameters must always be packed onto end of a method signature" +
    " using optional parameters before the non-optional parameters you'll recieve complier error");


/// <summary>
/// Cannot use optional parameter before required one
/// </summary>
//static void WasHere(string name = "Loki", string message)
//{

//}