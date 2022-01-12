using System;
using Tutorial.Common.Extensions;

int[] luckyNumbers = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

/// <summary>
/// As argument
/// </summary>
static void PrintNumbers(int [] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}

/// <summary>
/// Return as value
/// </summary>
static string [] GetMessageAsArray(string message)
{
    string[] messages = message.Split(" ");

    return messages;
}

PrintNumbers(luckyNumbers);

Console.WriteLine("----------------------------------");

GetMessageAsArray("Hello my name Loki I am a cat 🐈").Dump();

