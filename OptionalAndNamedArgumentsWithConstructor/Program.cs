using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace OptionalAndNamedArgumentsWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Optional and named arguments with constructors".DumpAsTitle();

            "We can create cat instance with various constructors".Dump();

            "We can use optional and named arguments to write less code , check Dog and Cat classes".Dump();

            ConsoleHelper.Seperate();

            Cat lOkum = new Cat();

            ConsoleHelper.Seperate();

            Cat loKI = new Cat(name:"loKİ");

            ConsoleHelper.Seperate();

            Cat borc = new Cat(age:5);

            ConsoleHelper.Seperate();

            Cat mah = new Cat(name:"Maho",age:2);

        }

        // With constructor chain
        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }

            // This is the 'master' constructor that does all the real work.
            public Dog(string name, int age)
            {
                Name = name;
                Age = age;

                "Dog - revisited default constructor".Dump();
            }

            public Dog() : this("Riley", int.MaxValue)
            {
                Name = "Riley";
                Age = int.MaxValue;

                "Dog - master constructor".Dump();
            }

            public Dog(string name) : this(name, 0)
            {
                "Dog- just name parameter".Dump();
            }

            public Dog(int age) : this("Riley", age)
            {
                "Dog- just age parameter".Dump();
            }


        }


        // With optional and named arguments
        public class Cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Cat(string name="Lokum",int age=int.MaxValue)
            {
                Name=name;
                Age = age;

                $"{Name}'s age is {Age}".Dump();
            }
        }
    }
}
