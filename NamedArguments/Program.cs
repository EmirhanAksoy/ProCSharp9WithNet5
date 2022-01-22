using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

"Named arguments".DumpAsTitle();

static void PrintMessage(string from, string to, string content)
{
    $"FROM: {from}".Dump();
    $"TO: {to}".Dump();
    $"CONTENT: {content}".Dump();
    DateTime.Now.ToString().Dump();
    ConsoleHelper.Seperate();
}

/// <summary>
/// Named arguments allow you to invoke a method by specifying parameter values in any order you choose.
/// </summary>
PrintMessage(content: "hey there !", from: "Me", to: "Loki");

/// <summary>
/// If positional arguments (used without name) are in the correct place you can mix them with named arguments.
/// </summary>
PrintMessage("Loki", content: "Meoww !!", to: "Me");


/// <summary>
/// We can use named arguments with optional parameters.
/// </summary>
static void PrintXYZCoordinates(int x = 0, int y = 0, int z = 0)
{
    x.Dump();
    y.Dump();
    z.Dump();
    ConsoleHelper.Seperate();
}

/// <summary>
/// Suppose that we just want to change z value before z there are x and y values 
/// Normally we have to assign value parameter x and y to set z 
/// To change z only we can use named arguments
/// </summary>
PrintXYZCoordinates(z: 5);

PrintXYZCoordinates(z: 785, x: 5);

