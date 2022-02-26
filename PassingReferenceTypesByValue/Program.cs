using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace PassingReferenceTypesByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Passing Reference Types by Value".DumpAsTitle();

            "Passing reference type by value is different from passing it by value".Dump();

            "If you pass a reference type without ref keyword ,you are passing it by value actually".Dump();

            "When we pass the reference type with value method can change the state of the object but can't assing it again".Dump();

            "Please check the below for exact scenario".Dump();

            ConsoleHelper.Seperate();
            
            Person oldPerson = new(100);

            "Person before changed".Dump();

            oldPerson.Age.Dump();

            oldPerson.Name.Dump();

            ChangeStateOfThePerson(oldPerson);

            "After change of person state".Dump();

            oldPerson.Age.Dump();

            oldPerson.Name.Dump();

            ReCreatePerson(oldPerson);

            "After reassing attemp of person".Dump();

            oldPerson.Age.Dump();

            oldPerson.Name.Dump();

        }

        public static void ChangeStateOfThePerson(Person person)
        {
            person.Age--;
            person.Name += "-Changed";
            
        }

        public static void ReCreatePerson(Person person)
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
