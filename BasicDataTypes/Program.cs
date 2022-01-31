using System;
using System.Numerics;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

"Basic Data Types".DumpAsTitle();

// With initial value
int a = 0;

$"=> Inital value ! {a}".Dump();

// With default keyword
int number = default;
DateTime date = default;
char character = default;


// With default contructor

int number2 = new int();
DateTime date2 = new(); // Without data type came with c#9
char character2 = new();


string name = "Emirhan";


$"=>Default keyword for {number.GetType()} is equal {number}".Dump();
$"=>Default keyword for {date.GetType()} is equal {date}".Dump();
$"=>Default keyword for {character.GetType()} is equal {character}".Dump();

ConsoleHelper.Seperate();

$"=>Default contructor for {number2.GetType()} is equal {number}".Dump();
$"=>Default contructor for {date2.GetType()} is equal {date}".Dump();
$"=>Default contructor for {character2.GetType()} is equal {character}".Dump();

ConsoleHelper.Seperate();

//These methods drived from System.Object
number.GetType();
number.ToString();
number.GetHashCode();
number.Equals(34);

ConsoleHelper.Seperate();

// Numerical data types 

Console.WriteLine("=> Max of int: {0}", int.MaxValue);
Console.WriteLine("=> Min of int: {0}", int.MinValue);
Console.WriteLine("=> Double epsilon : {0}", double.Epsilon);
Console.WriteLine("=> Positive infinity : {0}", double.PositiveInfinity);
Console.WriteLine("=> Negative infinity : {0}", double.NegativeInfinity);

ConsoleHelper.Seperate();

// Boolean 

Console.WriteLine("=> Boolean False String : {0}", Boolean.FalseString);
Console.WriteLine("=> Boolean False String : {0}", Boolean.TrueString);

ConsoleHelper.Seperate();

// Textual data types

Console.WriteLine("=> Char IsDigit : {0}", char.IsDigit('e'));
Console.WriteLine("=> Char IsLetter : {0}", char.IsLetter('2'));
Console.WriteLine("=> Char IsWhiteSpace : {0}", char.IsWhiteSpace("asdasd a", 6));
Console.WriteLine("=> Char IsPunctuation : {0}", char.IsPunctuation('?'));

ConsoleHelper.Seperate();

// DateTime and TimeSpan

Console.WriteLine($"Today is {DateTime.Now}");
Console.WriteLine($"TimeSpan is {new TimeSpan(4, 30, 0)}");
Console.WriteLine($"Subtract 15 from time span {new TimeSpan(4, 30, 0).Subtract(new TimeSpan(0, 15, 0))}");
Console.WriteLine($"Dayligth savings {DateTime.Now.IsDaylightSavingTime()}");

ConsoleHelper.Seperate();


// System.Numerics

BigInteger massiveNumber = BigInteger.Parse("999999999999999999999999999999999999999999999999999");

Console.WriteLine($"Value of big integer {massiveNumber}");

massiveNumber = massiveNumber + 1;

Console.WriteLine($"Value of big integer {massiveNumber}");
Console.WriteLine($"Is power two {massiveNumber.IsPowerOfTwo}");
Console.WriteLine($"Is even {massiveNumber.IsEven}");


BigInteger tooBig = BigInteger.Multiply(9999999999, BigInteger.Parse("999999999999999999999999999999999999999999999999999"));

Console.WriteLine($"Too big number {tooBig}");