using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

"Parameter modifiers - Ref keyword".DumpAsTitle();

//String example

/// <summary>
/// Strings are reference type but it's pass by value default in C#
/// We can pass it by reference with using ref keyword
/// No need to assing in caller method like out keyword beacuse we're passing value to an existing variable
/// </summary>
static void SwapCatsByReference(ref string bigCat, ref string smallCat)
{
    string cat = bigCat;
    bigCat = smallCat;
    smallCat = cat;
    cat.Dump();
    bigCat.Dump();
    smallCat.Dump();
}

/// <summary>
/// String passing without ref keyword to understand differ
/// </summary>
static void SwapCatsByValue(string bigOne, string smallOne)
{
    string cat = bigOne;
    bigOne = smallOne;
    smallOne = cat;
    cat.Dump();
    bigOne.Dump();
    smallOne.Dump();
}

string loki = "Loki";
string borc = "Borc";
string lokum = "Lokum";
string mah = "Mah";

SwapCatsByReference(ref borc, ref loki);

ConsoleHelper.Seperate();

SwapCatsByValue(lokum, mah);

ConsoleHelper.Seperate();

//System.In32 example

int ageOfLoki = 1;
int ageOfLokum = 2;
int ageOfBorc = 4;
int ageOfMah = 3;

/// <summary>
/// System.Int32 always pass by value in C# but with ref keyword we can make it pass by reference.
/// </summary>
static void SwapCatAgesWithReference(ref int olderOne, ref int youngerOne)
{
    int catAge = olderOne;
    olderOne = youngerOne;
    youngerOne = catAge;

    catAge.Dump();
    olderOne.Dump();
    youngerOne.Dump();
}

/// <summary>
/// System.Int32 passing without ref keyword to understand differ
/// </summary>
static void SwapCatAgesWitValue(int olderOne, int youngerOne)
{
    int catAge = olderOne;
    olderOne = youngerOne;
    youngerOne = catAge;

    catAge.Dump();
    olderOne.Dump();
    youngerOne.Dump();
}

SwapCatAgesWithReference(ref ageOfMah, ref ageOfLoki);

ConsoleHelper.Seperate();

SwapCatAgesWitValue(ageOfBorc, ageOfLokum);

ConsoleHelper.Seperate();

int a = 10;
int b = 10;

$"a = {a}".Dump();

$"b = {b}".Dump();

/// <summary>
/// Without ref keyword
/// </summary>
static void Add(int count,int initialValue)
{
    initialValue += count;
}

/// <summary>
/// With ref keyword
/// </summary>
static void Multiply(int count,ref int initialValue)
{
    initialValue *= count;
}

Add(5,a);

Multiply(4, ref b);

"a is passed by value".Dump();
"b is passed by reference".Dump();

$"a = {a}".Dump();

$"b = {b}".Dump();
