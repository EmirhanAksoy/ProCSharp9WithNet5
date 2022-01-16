using System;
using Tutorial.Common.Extensions;

"Static Local Function".DumpAsTitle();


/// <summary>
/// Local function can reach parent method variables directly
/// </summary>
static void PredictTheYearOfDeadth()
{
    int year = new Random().Next(2022, 2100);

    Print();

    void Print()
    {
        year++;

        Console.WriteLine(year);
    }
}

PredictTheYearOfDeadth();


/// <summary>
/// When use static keyword with local functions , complier gives error 'A static local function cannot contain a reference to 'year'.'
/// Uncommemt to see error
/// </summary>
//static void PredictTheYearOfDeadthForPerson(string name)
//{
//    int year = new Random().Next(2022, 2100);

//    Print();

//    static void Print()
//    {
//        year++;

//        Console.WriteLine($"{name} will die in {year}");
//    }
//}

//PredictTheYearOfDeadthForPerson();

/// <summary>
/// Static local function correct usage example
/// </summary>
static void PredictEndOfTheWorld(string message)
{
    int year = GetYear();

    GetMessage(message).Dump();

    $"End of the world {year}".Dump();

    static int GetYear() => new Random().Next(2022, 2100);

    static string GetMessage(string message) => $"Hey dude ! {message}";

}

PredictEndOfTheWorld("Omg ! We're gonna die ! ");