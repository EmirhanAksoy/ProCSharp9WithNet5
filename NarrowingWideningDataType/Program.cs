using System;

int number = default;

byte byteNumber = 133;

//WIDENING - No compile time error beacuse System.Int32 range covers System.Byte . There is no data loss 

number = byteNumber;

Console.WriteLine($"WIDENING Number : { number }");

long longNumber = 6745674567456754745;

//NARROWING - Compile time error beacuse System.Long range is covers  System.Int32. There might be a data loss

// number = longNumber;


// Explicit Cast with unboxing , integer will be overflow with no exception and data loss !! 

number = (int)longNumber;

Console.WriteLine($"NARROWING Number : { number }");


// If we want to check overflow-underflow statuations we  should use checked keyword

try
{
    number = checked((int)longNumber);

    Console.WriteLine($"NARROWING Number : { number }");
}
catch (System.OverflowException overflowException) 
{
    Console.WriteLine(overflowException.Message);
}

// We can chage "Check for arithmetic overflow" options from "Build" section of project properties

// If we do not want to check overflow-underflow statuations we  should use checked keyword


try
{
    unchecked
    {
        number = (int)longNumber;

        Console.WriteLine($"NARROWING Number : { number }");
    }
    
}
catch (System.OverflowException overflowException)
{
    Console.WriteLine(overflowException.Message);
}





