using System;
using System.Linq;
using Tutorial.Common.Extensions;

"Local Functions".DumpAsTitle();


// Example 1:

static void PrintFullName(string firstName, string middleName, string lastname)
{
    if (!isValidText(firstName))
        throw new ArgumentException($"{nameof(firstName)} is null or emtpty string ");

    if (!isValidText(lastname))
        throw new ArgumentException($"{nameof(lastname)} is null or emtpty string ");

    Print($"{firstName} {middleName} {lastname}");

    /// <summary>
    /// Local method
    /// </summary>
    void Print(string text)
    {
        Console.WriteLine(text);
    }

    /// <summary>
    /// Local function with lamda expression
    /// </summary>
    bool isValidText(string text) => !string.IsNullOrEmpty(text);
}


PrintFullName("Alexander", "Graham", "Bell");


// Example 2:

static int GetSum(params int[] numbers)
{

    if (Sum(numbers) > 0)
    {
        // Do something

        Console.WriteLine("Sum is greater than zero.");
    }

    return Sum(numbers);

    /// <summary>
    /// Local function
    /// </summary>
    int Sum(params int[] numbers)
    {
        return numbers.Sum(x => x);
    }
}

GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9, 0).Dump();


