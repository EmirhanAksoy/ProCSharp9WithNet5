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

$"=> Max of int: {int.MaxValue}".Dump();
$"=> Min of int: {int.MinValue}".Dump();
$"=> Double epsilon : {double.Epsilon}".Dump();
$"=> Positive infinity : {double.PositiveInfinity}".Dump();
$"=> Negative infinity : {double.NegativeInfinity}".Dump();

ConsoleHelper.Seperate();

// Boolean 

$"=> Boolean False String : {Boolean.FalseString}".Dump();
$"=> Boolean False String : {Boolean.TrueString}".Dump();

ConsoleHelper.Seperate();

// Textual data types

$"=> Char IsDigit : {char.IsDigit('e')}".Dump();
$"=> Char IsLetter : {char.IsLetter('2')}".Dump();
$"=> Char IsWhiteSpace : {char.IsWhiteSpace("asdasd a", 6)}".Dump();
$"=> Char IsPunctuation : {char.IsPunctuation('?')}".Dump();

ConsoleHelper.Seperate();

// DateTime and TimeSpan

$"Today is {DateTime.Now}".Dump();
$"TimeSpan is {new TimeSpan(4, 30, 0)}".Dump();
$"Subtract 15 from time span {new TimeSpan(4, 30, 0).Subtract(new TimeSpan(0, 15, 0))}".Dump();
$"Dayligth savings {DateTime.Now.IsDaylightSavingTime()}".Dump();

ConsoleHelper.Seperate();


// System.Numerics

BigInteger massiveNumber = BigInteger.Parse("999999999999999999999999999999999999999999999999999");

$"Value of big integer {massiveNumber}".Dump();

massiveNumber = massiveNumber + 1;

$"Value of big integer {massiveNumber}".Dump();
$"Is power two {massiveNumber.IsPowerOfTwo}".Dump();
$"Is even {massiveNumber.IsEven}".Dump();


BigInteger tooBig = BigInteger.Multiply(9999999999, BigInteger.Parse("999999999999999999999999999999999999999999999999999"));

$"Too big number {tooBig}".Dump();