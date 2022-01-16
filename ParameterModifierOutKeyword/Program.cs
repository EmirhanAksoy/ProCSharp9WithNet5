using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

"Parameter modifiers - Out keyword".DumpAsTitle();

/// <summary>
/// Out keyword parameters are passed by reference, but must be assing in the caller method/function
/// If it is not assinged compiler gives error to try comment line 13
/// </summary>
/// 
static void Sum(int x, int y, out int result)
{
    result = x + y;

    $"{x} + {y} = {result}".Dump();
}

Sum(45, 32, out int result);

result.Dump();

static void FillTheseValues(out string name, out int age, out string eyeColor)
{
    name = "Loki";
    age = 1;
    eyeColor = "Brown";
}

FillTheseValues(out string name, out int age, out string eyeColor);

$"Name is passed by reference by out keyword : {name}".Dump();
$"Age is passed by reference by out keyword : {age}".Dump();
$"Eye color is passed by reference by out keyword : {eyeColor}".Dump();

ConsoleHelper.Seperate();

"Discarding out parameters".DumpAsTitle();

static void ConcatWords(out string fullText, out int totalLenght, params string[] words)
{
    fullText = string.Empty;
    totalLenght = 0;

    for (int i = 0; i < words.Length; i++)
    {
        fullText += words[i] + " ";
        totalLenght += words[i].Length;
    }


    fullText.Dump();
}


/// <summary>
/// If we dont need out parameter value we can discard it like this.
/// Also its good for performance
/// </summary>
ConcatWords(out _, out _, "Hello", "I", "am", "Loki");

