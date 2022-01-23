using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace Enums
{
    public class Program
    {
        static void Main(string[] args)
        {
            "Enums".DumpAsTitle();

            ConsoleHelper.Frame("An enumeration type (or enum type) is a value type defined " +
                "by a set of named constants of the underlying integral numeric type. ");

            Sound.GetSound(Animal.Cat);

            // Enums gain functionality from System.Enum (such as methods)
            // GetUnderlyingType returns storage type of enum
            Enum.GetUnderlyingType(typeof(Animal)).Dump();

            // We can get enum name by .ToString() method of System.Enum
            Animal.Dragon.ToString().Dump();

            // We can get value of enums by GetHashCode method or with unboxing
            Animal.Unicorn.GetHashCode().Dump();
            ((int)Avengers.Thor).Dump();

            ConsoleHelper.Seperate();

            // We can get values of enum by GetValues method
            Array values = Enum.GetValues(typeof(Animal));

            for (int i = 0; i < values.Length; i++)
            {
                values.GetValue(i).Dump();
            }
        }
    }
    

    /// <summary>
    /// By default, first element is set to 0(zero), followed by an n+1 programming
    /// </summary>
    public enum Answer
    {
        Yes, // 0
        No   // 1
    }

    /// <summary>
    /// We can change first element value and no need a sequential ordering
    /// </summary>
    public enum Avengers
    {
        DrStrange = 1,
        Thor = 100,
        SpiderMan = 5,
        IronMan = 666,
        CaptainMarwell, // 667
        CaptainAmerica, // 668
        Hulk            // 669
    }

    // We can use them as parameter,variable,return value and so forth

    /// <summary>
    /// By default enum storage type is System.Int32(int) but we can change the type of it
    /// </summary>

    public enum Animal
    {
        Cat,
        Dog,
        Dragon,
        Unicorn,
        //Byte 0-255 cant assing 999 value, to check uncomment following element
        // Trol = 999
    }
    public static class Sound
    {
        public static void GetSound(Animal animal)
        {
            Animal selectedAnimal = animal;

            switch (selectedAnimal)
            {
                case Animal.Cat:
                    "Meow".Dump();
                    break;
                case Animal.Dog:
                    "Bark".Dump();
                    break;
                case Animal.Dragon:
                    "Roar".Dump();
                    break;
                case Animal.Unicorn:
                    "Neigh".Dump();
                    break;
                default:
                    break;
            }

        }
    }

}





