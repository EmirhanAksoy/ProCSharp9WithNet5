using System;
using Tutorial.Common.Extensions;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Constructors".DumpAsTitle();

            "Every C# class has default constructor".Dump();

            "Default constructor never takes any argument".Dump();


            // Default constructor does not contain parameters.
            Car car = new Car();

            // Customized default constructor
            Cat cat = new Cat();

            cat.Name.Dump();


            "We can define custom constructors that takes arguments".Dump();

            "To create multiple custom constructors we can use overloading".Dump();

            Horse horse = new Horse(5,"Shadow");

            $"{horse.Name} is like hurricane".Dump();

        }

        // Has default constructor
        public class Car
        {
            public string Name { get; set; }
            public string Description { get; set; }

        }

        // Has customized default constructor
        public class Cat
        {
            public int Id { get; set; }
            public int Age { get; set; }
            public string Name { get; set; }
             
            // Custom default constructor
            public Cat()
            {
                Id = 1;
                Age = 2;
                Name = "Loki";
            }
        }

        // Has multiple custom consturctors
        public class Horse
        {
            public string Id { get; set; }
            public int Age { get; set; }
            public string Name { get; set; }

            public Horse()
            {

            }

            public Horse(int age,string name)
            {
                this.Id = Guid.NewGuid().ToString();
                this.Age = age;
                this.Name = name;
            }


            public Horse(string id,int age, string name)
            {
                this.Id = id;
                this.Age = age;
                this.Name = name;
            }



        }
    }
}
