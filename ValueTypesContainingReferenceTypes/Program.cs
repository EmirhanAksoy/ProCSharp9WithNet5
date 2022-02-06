using System;
using System.Runtime.InteropServices;
using Tutorial.Common.Extensions;

namespace ValueTypesContainingReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Value Type Containing Reference Types".DumpAsTitle();

            "NOTE : By default, when a value type contains other reference types, assingment results in a copy of the references".Dump();


            Point p1 = new Point("Test", 1, 2);
            Point p2 = p1;

            p1.Display();
            p2.Display();

            p1.PointInfo.Info = "Break Point";

            p1.Display();  // Break Point 
            p2.Display();  // Break Point

            "Reference types in value types point the same object in the memory".Dump();

            // Check memory addresses are equal
            GetObjectAddress(p1.PointInfo).Dump();
            GetObjectAddress(p2.PointInfo).Dump();

        }

        public static string GetObjectAddress(object obj)
        {
            GCHandle objHandle = GCHandle.Alloc(obj, GCHandleType.WeakTrackResurrection);
            var pointer = GCHandle.ToIntPtr(objHandle);
            objHandle.Free();

            return "0x" + pointer.ToString("X");
        }
    }

    public class PointInfo
    {
        public string Info;

        public PointInfo(string info)
        {
            Info = info;
        }
    }


    public struct Point
    {
        public PointInfo PointInfo;
        public int X;
        public int Y;


        public Point(string info,int x,int y)
        {
            PointInfo = new PointInfo(info);
            X = x;
            Y = y;  
        }

        public void Display()
        {
            $"Info :{PointInfo.Info}".Dump();
            $"X:{X}".Dump();
            $"Y:{Y}".Dump();

        }
    }

}
