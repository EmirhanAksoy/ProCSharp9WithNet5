using System;



ParseFromString();
ParseFromStringWithTryParse();

static void ParseFromString()
{
    bool b = bool.Parse("true");
    bool bUpper = bool.Parse("TRUE");

    Console.WriteLine($"Boolean parse from string is equal {b}");
    Console.WriteLine($"Boolean parse from upper case string is equal {bUpper}");


    int i = int.Parse("48");

    Console.WriteLine($"Integer parse from string is equal {i}");


    char w = char.Parse("w");

    Console.WriteLine($"Char parse from string is equal {w}");
}


static void ParseFromStringWithTryParse()
{
    // If try parse method cannot parse the data , set the data default value of it example: if data int try-parse method result will be 0.
    if (bool.TryParse("Hello", out bool result))
    {
        Console.WriteLine($"String converted to boolean succesfully with result : {result}");

    }
    else
    {
        Console.WriteLine($"String cannot be converted to boolean , result : {result}");
    }


    if (int.TryParse("Number", out int integerResult))
    {
        Console.WriteLine($"String converted to integer succesfully with result : {integerResult}");

    }
    else
    {
        Console.WriteLine($"String cannot be converted to integer , result : {integerResult}");
    }
}