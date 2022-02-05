using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace ValueTypeReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Value type & Reference type".DumpAsTitle();

            "All value types drived from System.ValueType".Dump();

            "Role of system value type is to ensure that the drived type is allocated on the STACK".Dump();

            "Functionally, the only purpose of the System.Value is to override the virtual methods of defined by System.Object".Dump();

            "When a value type falls out the defining scope,its removed from memory immediately".Dump();

            "NOTE: C# structures do have not an identically named representation in the .Net Core Lib but they are implicitly drived from System.ValueType".Dump();


            object value = null;

            System.ValueTuple valueType = new System.ValueTuple();

            Point p1 = new Point(1,2);
            Point p2 = p1;

            p1.Display();
            p2.Display();

            p1.X = 100;

            p1.Display(); // X:100-Y:2
            p2.Display(); // X:1-Y:2


            "We created two copies of the Point, their values independent because they are value type".Dump();

            PointRef p_1 = new PointRef(1,2);
            PointRef p_2 = p_1;

            p_1.Display();
            p_2.Display();

            p_1.X = 100;      
            
            p_1.Display(); // X:100-Y:2
            p_2.Display(); // X:100-Y:2

            "In this case we are pointing the same object on the garvage collected heap,their value will be the same each other".Dump();

        }

        /// <summary>
        /// Object lifetime for value types is limited with defining scope
        /// </summary>
        public static void LocalValueTypes()
        {
            //int is a really a System.Int32 structure , to check click int press F12
            int i = 0;

            //Point is structure type
            Point point = new Point(23,45);

        }// i and point will be popped off the stack here!

    }

    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            $"X:{X} - Y:{Y}".Dump();
        }
    }

    public class PointRef
    {
        public int X;
        public int Y;

        public PointRef(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            $"X:{X} - Y:{Y}".Dump();
        }
    }
}
