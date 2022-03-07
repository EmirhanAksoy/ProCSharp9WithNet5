using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace OperatingOnNullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Operating on nullable types".DumpAsTitle();

            ConsoleHelper.Frame("Null-Coalescing Operator : ??");
            
            int? score = null;

            //If score's value is null it will be set 100
            $"Score value is null :{score is null}".Dump();

            score = (score ?? 100);

            $"Score value is :{score}".Dump();

            score = null;

            //Also we can use .HasValue Property

            if (!score.HasValue)
                score = 100;

            $"Score value is :{score}".Dump();

            score = null;

            ConsoleHelper.Frame("Null-Coalescing Assingment Operator : ??=");

            //If score's value is null it will be set 100
            score ??= 100;

            $"Score value is :{score}".Dump();

            ConsoleHelper.Frame("Null Conditional Operator : item?.value");

            int[] luckyNumbers = null;

            int? luckyNumbersLength = luckyNumbers?.Length;

            luckyNumbersLength.Dump();

            (luckyNumbersLength ?? 0).Dump();
            (luckyNumbers?.Length ?? 0).Dump();

            Person? person = null;

            person?.Name.Dump(); 
        }

        class Person
        {
            public string Name { get; set; }
        }
    }
}
