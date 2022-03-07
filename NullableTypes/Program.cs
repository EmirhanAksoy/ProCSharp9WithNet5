using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Nullable Value/Reference Type".DumpAsTitle();

            ConsoleHelper.Frame("Nullable Value Type");

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

            nullableInt.Dump();
            nullableDouble.Dump();
            nullableBool.Dump();
            nullableChar.Dump();

            "The ? suffix notation is a shorthand for creating an instance of the generic System.Nullable<T> structure type.".Dump();

            // Define some local nullable types using Nullable<T>.
            Nullable<int> _nullableInt = 10;
            Nullable<double> _nullableDouble = 3.14;
            Nullable<bool> _nullableBool = null;
            Nullable<char> _nullableChar = 'a';
            Nullable<int>[] _arrayOfNullableInts = new Nullable<int>[10];

            _nullableInt.Dump();
            _nullableDouble.Dump();
            _nullableChar.Dump();
            _nullableBool.Dump();

            (_nullableInt.GetType() == nullableInt.GetType()).Dump();

            ConsoleHelper.Frame("Nullable Reference Type");

            @"The project file setting makes the entire project a nullable context. The nullable context allows to use the nullable annotation (?).".Dump();
            
            "We can set nullable context option as Enable(default),Warnings,Annotations and Disable".Dump();

            "ENABLE:Nullable annotations are enabled, and nullable warnings are enabled.".Dump();
            "WARNINGS:Nullable annotations are disabled, and nullable warnings are enabled.".Dump();
            "ANNOTATIONS:Nullable annotations are enabled, and nullable warnings are disabled.".Dump();
            "DISABLED:Nullable annotations are disabled, and nullable warnings are disabled.".Dump();

            "Nullable reference types follow many of the same rules as nullable value types.".Dump();

            @"Nullable reference types use the same symbol (?) to indicate that they are nullable. However, this is not
              a shorthand for using System.Nullable<T>, as only value types can be used in place of T.".Dump();

           

            "If reference type is not nullable, code generates warning".Dump();

            Person? person = null;
            Person person1 = new();
            string value = string.Empty;

            //Warning CS8600 Converting null literal or possible null value to non-nullable type
            person1 = person;


            // We can disable nullable context warning
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            person1 = person;
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            // Also we can disable nullable context which is set  at the project level

            person1 = null;
            value = null;

            #nullable disable
            person1 = null;
            value = null;
            #nullable restore

            @"As a final note, the nullable reference types do not have the HasValue and Value properties, as those are
            supplied by System.Nullable<T>.".Dump();

        }

        public class Person
        {
            public string Id { get; set; }

            public string Username { get; set; }
        }
    }
}
