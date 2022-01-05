using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHi();
            person.Beep();
            person.SayBye();
        }
    }

    public abstract class Base
    {
        public Base(string message)
        {
            Console.WriteLine(message);
        }
        public virtual void SayHi()
        {
            Console.WriteLine("Hi there !");
        }
        public virtual void Beep()
        {
            Console.Beep();
        }
        public virtual void SayBye()
        {
            Console.WriteLine("Bye bye !");
        }
        
    }

    public interface IBase
    {
        void SayHi();
        void Beep();
        void SayBye();
    }

    public class Person : Base,IBase
    {
        public Person():base("I am Emirhan Aksoy")
        {

        }
    }
}
