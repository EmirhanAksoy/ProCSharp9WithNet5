using System;
using System.Linq;
using Tutorial.Common.Extensions;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Tuples".DumpAsTitle();

            "It is useful for returning multiple values".Dump();

            "To create a tuple, simply enclose the values to be assigned to the tuple in parentheses.They do not all have to be the same data type".Dump();

            (string username, string password) credentials = ("admin", "Admin1*.");

            $"Username: {credentials.username}".Dump();
            $"Password: {credentials.password}".Dump();

            "Specific names can also be added to each property in the tuple on either the right side or the left side of the statement.".Dump();

            credentials = (username: "test_user", password: "Test2022!*");

            $"Username: {credentials.username}".Dump();
            $"Password: {credentials.password}".Dump();

            "While it is not a compiler error to assign names on both sides of the statement, if you do, the right side WILL BE IGNORED, and only the left-side names are used.".Dump();

#pragma warning disable CS8123 // The tuple element name is ignored because a different name or no name is specified by the assignment target.
            credentials = (username_test: "user_test", password_test: "Test2029!*");
#pragma warning restore CS8123 // The tuple element name is ignored because a different name or no name is specified by the assignment target.

            $"Username: {credentials.username}".Dump();
            $"Password: {credentials.password}".Dump();

            var luckyNumbers = ("Start", 1, 2, 3, 4, 5, 6, 7, "Finish");

            luckyNumbers.Item1.Dump();
            luckyNumbers.Item2.Dump();
            luckyNumbers.Item3.Dump();
            luckyNumbers.Item4.Dump();
            luckyNumbers.Item5.Dump();
            luckyNumbers.Item6.Dump();
            luckyNumbers.Item7.Dump();
            luckyNumbers.Item8.Dump();
            luckyNumbers.Item9.Dump();

            "We have ability for C# to infer the variable names of tuples".Dump();

            // directly using foo object prop names !!
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            $"{bar.Prop1};{bar.Prop2}".Dump();

            @"When testing for inequality, the comparison operators will perform IMPLICIT conversions on data types within the tuples, including
            comparing nullable and non-nullable tuples and/or properties.".Dump();

            var left = (a: 5, b: 10);

            (int? a, int? b) nullableMembers = (5, 10);

            (left == nullableMembers).Dump(); // True

            (long a, long b) longTuple = (5, 10);

            (left == longTuple).Dump(); // True

            (long a, int b) longFirst = (5, 10);

            (int a, long b) longSecond = (5, 10);

            (longFirst == longSecond).Dump(); // True

            "We can use them as a return value of the methods".Dump();

            var samples = FillTheseValues();
            $"Int is: {samples.a}".Dump();
            $"String is: {samples.b}".Dump();
            $"Boolean is: {samples.c}".Dump();

            "Tuples also useful deconstructions".Dump();

            (string firstName, string middleName, string lastName) = SplitParts("Walter Bruce Willis");

            firstName.Dump();
            middleName.Dump();
            lastName.Dump();

            "We can discard values with an underscore (_) placeholder if dont need them".Dump();

            (_,_, string lol) = SplitParts("Are U Mine!");

            lol.Dump();
        }

        /// <summary>
        /// Out keyword for returning multiple value from method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        /// <summary>
        /// Instead of out key word we can use tuples for returning multiple value from method
        /// </summary>
        /// <returns></returns>
        static (int a, string b, bool c) FillTheseValues()
        {
            return (9, "Enjoy your string.", true);
        }

        /// <summary>
        /// Splits values with space and return them as (string,string,string) tuple
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        static (string first, string middle, string last) SplitParts(string fullName)
        {
            string [] nameParts = fullName.Split(' ');

            if (nameParts != null && nameParts.Any())
                return (nameParts[0], nameParts[1], nameParts[2]);

            return (string.Empty, string.Empty, string.Empty);
        }
    }
}
