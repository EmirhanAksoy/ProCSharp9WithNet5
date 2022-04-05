using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace ChainingConstructorCalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Chaining Constructor Calls Using this".DumpAsTitle();

            "Another use of the this keyword is to design a class using a technique termed constructor chaining".Dump();

            ConsoleHelper.Seperate();

            Cat lokum = new Cat("lOKUM");

            ConsoleHelper.Seperate();

            Cat lOKi= new Cat(2);

            ConsoleHelper.Seperate();

            Dog riley = new Dog("RIley");

            ConsoleHelper.Seperate();

            Dog sun = new Dog(4);

            ConsoleHelper.Seperate();

            "Constructor chain helps to write less code and its easy to maintain".Dump();

            "We can observe that when we use constructor chain master consturctor will be executed first".Dump();
        }

        // Without constructor chain
        public class Cat
        {
            public string Name { get; set; }
            public int Age{ get; set; }

            public Cat()
            {
                Name = "Lokum";
                Age = int.MaxValue;

                "Cat - revisited default constructor".Dump();
            }

            public Cat(string name,int age)
            {
                Name = name;
                Age = age;

                "Cat - master constructor".Dump();
            }

            public Cat(string name)
            {
                Name = name;
                Age = 0;

                "Cat - just name parameter".Dump();
            }

            public Cat(int age)
            {
                Name = "Thor";
                Age = age;

                "Cat - just age parameter".Dump();
            }


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

            public Dog() : this("Riley",int.MaxValue)
            {
                Name = "Riley";
                Age = int.MaxValue;

                "Dog - master constructor".Dump();
            }

            public Dog(string name) : this(name,0)
            {
                "Dog- just name parameter".Dump();
            }

            public Dog(int age) : this("Riley",age)
            {
                "Dog- just age parameter".Dump();
            }


        }
    }
}
