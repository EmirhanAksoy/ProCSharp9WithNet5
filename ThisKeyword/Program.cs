using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace ThisKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Understanding this Keyword".DumpAsTitle();

            "C# supplies a this keyword that provides access to the current class instance.".Dump();

            "If incoming parameter is named identically to a data field of the class its useful to resolve scope ambiguity".Dump();


            ConsoleHelper.Seperate();

            // Without this keyword
            Cat sugar = new Cat(2);

            $"Sugar's age is {sugar.Age}".Dump();


            ConsoleHelper.Seperate();

            // With this keyword
            Cat lOkI = new Cat("lOkI");

            $"{lOkI.Name} is my best friend ".Dump();

        }


        public class Cat
        {
            public string Name { get; set; }

            public int Age { get; set; }

            // Do this
            public Cat(string Name)
            {
                //C# compiler will display a warning message informing you that you have assigned a variable back to itself
                //Name = Name;
                //We can use this keyword in here to resolve ambiguity

                this.Name = Name;
            }

            // Dont do this
            public Cat(int Age)
            {
                Age = Age;  
            }
        }






    }
}
