using System;
using System.Numerics;


// With initial value
int a = 0;

Console.WriteLine("=> Inital value ! {0}", a);

// With default keyword
int number = default;
DateTime date = default;
char character = default;


// With default contructor

int number2 = new int();
DateTime date2 = new(); // Without data type came with c#9
char character2 = new();


string name = "Emirhan";


Console.WriteLine("=>Default keyword for {0} is equal {1}", number.GetType(), number);
Console.WriteLine("=>Default keyword for {0} is equal {1}", date.GetType(), date);
Console.WriteLine("=>Default keyword for {0} is equal {1}", character.GetType(), character);

Console.WriteLine("--------------------------------------------");

Console.WriteLine("=>Default contructor for {0} is equal {1}", number2.GetType(), number);
Console.WriteLine("=>Default contructor for {0} is equal {1}", date2.GetType(), date);
Console.WriteLine("=>Default contructor for {0} is equal {1}", character2.GetType(), character);

Console.WriteLine("--------------------------------------------");

//These methods drived from System.Object
number.GetType();
number.ToString();
number.GetHashCode();
number.Equals(34);

Console.WriteLine("--------------------------------------------");

// Numerical data types 

Console.WriteLine("=> Max of int: {0}", int.MaxValue);
Console.WriteLine("=> Min of int: {0}", int.MinValue);
Console.WriteLine("=> Double epsilon : {0}", double.Epsilon);
Console.WriteLine("=> Positive infinity : {0}", double.PositiveInfinity);
Console.WriteLine("=> Negative infinity : {0}", double.NegativeInfinity);

Console.WriteLine("--------------------------------------------");

// Boolean 

Console.WriteLine("=> Boolean False String : {0}", Boolean.FalseString);
Console.WriteLine("=> Boolean False String : {0}", Boolean.TrueString);

Console.WriteLine("--------------------------------------------");

// Textual data types

Console.WriteLine("=> Char IsDigit : {0}", char.IsDigit('e'));
Console.WriteLine("=> Char IsLetter : {0}", char.IsLetter('2'));
Console.WriteLine("=> Char IsWhiteSpace : {0}", char.IsWhiteSpace("asdasd a", 6));
Console.WriteLine("=> Char IsPunctuation : {0}", char.IsPunctuation('?'));

Console.WriteLine("--------------------------------------------");

// DateTime and TimeSpan

Console.WriteLine($"Today is {DateTime.Now}");
Console.WriteLine($"TimeSpan is {new TimeSpan(4, 30, 0)}");
Console.WriteLine($"Subtract 15 from time span {new TimeSpan(4, 30, 0).Subtract(new TimeSpan(0, 15, 0))}");
Console.WriteLine($"Dayligth savings {DateTime.Now.IsDaylightSavingTime()}");

Console.WriteLine("--------------------------------------------");


// System.Numerics

BigInteger massiveNumber = BigInteger.Parse("999999999999999999999999999999999999999999999999999");

Console.WriteLine($"Value of big integer {massiveNumber}");

massiveNumber = massiveNumber + 1;

Console.WriteLine($"Value of big integer {massiveNumber}");
Console.WriteLine($"Is power two {massiveNumber.IsPowerOfTwo}");
Console.WriteLine($"Is even {massiveNumber.IsEven}");


BigInteger tooBig = BigInteger.Multiply(9999999999, BigInteger.Parse("999999999999999999999999999999999999999999999999999"));

Console.WriteLine($"Too big number {tooBig}");