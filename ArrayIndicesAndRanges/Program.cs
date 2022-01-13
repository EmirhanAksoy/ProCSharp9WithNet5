using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

string[] myCats = new string[] { "Lokum", "Loki", "Borc" , "Mah"};


"The Range Operator [0..2]".DumpAsTitle();

/// <summary>
/// The range operator
/// </summary>
foreach (var item in myCats[0..2])
{
    item.Dump();
}


int[] luckyNumbers = new int[] { 1, 8, 4, 888, 2, 455 };

/// <summary>
/// System.Range definition
/// </summary>
Range range = 2..4;

foreach (var item in luckyNumbers[range])
{
    item.Dump();
}

ConsoleHelper.Seperate();

"Indices Operator ^ ".DumpAsTitle();


string[] colors = new string[] { "RED", "BLUE", "GREEN", "YELLOW", "BLACK" };

/// <summary>
/// Colors length is 5
/// ^ operator gives index array.length - selectedNumber
/// ^1 => 5(array.length) - 1 = 4 (selected index) => colors[4] => BLACK
/// ^0 would caluse error 5-0= 5 => colors[5] => throws IndexOutOfRangeException
/// </summary>
for (int i = 1; i <= colors.Length; i++)
{
    Index index = ^i;

    $"{colors.Length} - {i} = {colors.Length - i}".Dump();

    colors[index].Dump();
}



