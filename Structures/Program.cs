using System;
using Tutorial.Common.Extensions;

namespace Structures
{
    public class Program
    {
        static void Main(string[] args)
        {

            "Understanding Structure".DumpAsTitle();

            // Error ! Did not assing Y value , to check unccomment
            // If we dont use default constructor(parameterless constr.) it is required to assing all the fields of struct 
            //Point p1;
            //p1.x = 100;
            //p1.Display();

            //Its okey all fields assigned before use
            Point p1;
            p1.x = 100;
            p1.y = 500;
            p1.Display();


            //If we want set fields automatically with default values we can use default constructor
            Point p2 = new();
            p2.Display();

            //Also we can use custom constructor to assing fields
            Point p3 = new(32, 79);
            p3.Display();

        }
    }
}

/// <summary>
/// We can think of a structure as a lightweight class type
/// Supports encapsulation (by access modifiers public,private etc.)
/// </summary>
struct Point
{
    public int x;
    public int y;

    public Point(int xValue,int yValue)
    {
        x = xValue;
        y = yValue;
    }

    public void Increment()
    {
        x++;
        y++;
    }

    public void Decrement()
    {
        x--;
        y--;    
    }

    public void Display()
    {
        $"X:{x} - Y:{y}".Dump();
    }
}
