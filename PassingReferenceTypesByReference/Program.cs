using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace PassingReferenceTypesByReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Passing Reference Types by Reference".DumpAsTitle();

            "If you pass a reference type with ref keyword ,you are passing it by reference".Dump();

            "When we pass the reference type with reference method can change the state of the object ,also able to reassing".Dump();

            "Please check the below for exact scenario".Dump();

            ConsoleHelper.Seperate();

            Person oldPerson = new(100);

            "Person before changed".Dump();

            oldPerson.Age.Dump();

            oldPerson.Name.Dump();

            ChangeStateOfThePerson(ref oldPerson);

            "After change of person state".Dump();

            oldPerson.Age.Dump();

            oldPerson.Name.Dump();

            ReCreatePerson(ref oldPerson);

            "After reassing attemp of person".Dump();

            oldPerson.Age.Dump();

            oldPerson.Name.Dump();

        }

        public static void ChangeStateOfThePerson(ref Person person)
        {
            person.Age--;
            person.Name += "-Changed";

        }

        public static void ReCreatePerson(ref Person person)
        {
            person = new();
        }
    }

    public class Person
    {
        public Person(int age = 0)
        {
            Id = Guid.NewGuid().ToString();
            Name = $"Person-{Id}";
            Age = age;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
