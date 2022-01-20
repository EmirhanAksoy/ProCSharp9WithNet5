using System;
using System.Linq;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

"Parameter modifiers - Params keyword".DumpAsTitle();


/// <summary>
/// Parameter without params keyword
/// </summary>
static double CalculateAvarage(double [] values)
{
    return values.Sum() / values.Length;
}

CalculateAvarage(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10.2, 23423.345 }).Dump();

/// <summary>
/// Can't call without dobule [] parameter 
/// </summary>
//CalculateAvarage();

/// <summary>
/// Using params keyword
/// Params keyword easy to work with single array parameters
/// </summary>
static double CalculateAvarageWithParams(params double[] values)
{
    double sum = 0;
    
    if(values.Length == 0)
        return sum;

    for (int i = 0; i < values.Length;i++)
           sum+= values[i];

    return sum / values.Length;
}

ConsoleHelper.Seperate();

"Array parameter".Dump();
/// <summary>
/// We can use double array as a parameter
/// </summary>
CalculateAvarageWithParams(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10.2, 23423.345 }).Dump();

ConsoleHelper.Seperate();

"Comma-delimited parameters".Dump();
/// <summary>
/// We can use comma-delimited double list as a parameter
/// </summary>
CalculateAvarageWithParams(1, 2, 3, 4, 5, 6, 7, 8, 9, 10.2, 23423.345).Dump();

ConsoleHelper.Seperate();

"Empty parameter".Dump();
/// <summary>
/// We can pass empty
/// </summary>
CalculateAvarageWithParams().Dump();

// IMPORTANT NOTE : To avoid ambigutiy, C# demands a method support only a single params argument
// which must be the final argument in the parameter list .