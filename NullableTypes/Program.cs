using System;
using Tutorial.Common.Extensions;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Nullable Type".DumpAsTitle();

            "Value types can never be assigned the value of null, as that is used to establish an empty object reference.".Dump();

            // Compiler errors!
            // Value types cannot be set to null!
            // Uncomment next two lines for checking 
            // bool myBool = null;
            // int myInt = null;

            "C# supports the concept of nullable data types. Simply put, a nullable type can represent all the values of its underlying type, plus the value null.".Dump();

            "To define a nullable variable type, the question mark symbol (?) is suffixed to the underlying data type.".Dump();

            "Extremely helpful when working with relational databases, given that it is quite common to encounter undefined columns in database tables".Dump();

            // Define some local nullable variables.
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];

            "The ? suffix notation is a shorthand for creating an instance of the generic System.Nullable<T> structure type.".Dump();

            // Define some local nullable types using Nullable<T>.
            Nullable<int> _nullableInt = 10;
            Nullable<double> _nullableDouble = 3.14;
            Nullable<bool> _nullableBool = null;
            Nullable<char> _nullableChar = 'a';
            Nullable<int>[] _arrayOfNullableInts = new Nullable<int>[10];
        }
    }
}
