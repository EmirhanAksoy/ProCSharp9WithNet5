using System;
using Tutorial.Common.Extensions;

"Parameter modifiers - In keyword".DumpAsTitle();

/// <summary>
/// Passing large objects (such as a large struct) parameters by value-
/// (without a modifier) may cause memory pressure.Using modifiers may reduce this pressure
/// In keyword helps pass by reference and prevents the called method from modifying the values and make them readonly
/// </summary>
static void Sum(in int a,in int b)
{
    // To check uncomment line 10
    //Error CS8331  Cannot assign to variable 'in int' because it is a readonly variable 
    //a = 5;

    int result = a + b;

    result.Dump();
}

Sum(99999, 2344);

// NOTE : If no need to assing parameters in the caller method in keyword fits there.

/// <summary>
/// No need a and b pass by value because when value types passed by value they are copied(internally)
/// Convert method like below
/// </summary>
static void Multiply(int a ,int b)
{
    var result = a * b;

    result.Dump();
}

/// <summary>
/// Correct usage
/// </summary>
static void MultiplyCorrectly(in int a, in int b)
{
    var result = a * b;

    result.Dump();
}

Multiply(999999, 99999999);

MultiplyCorrectly(9988, 999999);


