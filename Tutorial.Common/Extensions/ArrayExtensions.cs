using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Common.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Integer array extension for print values
        /// </summary>
        /// <param name="values"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void Dump(this int [] values)
        {
           if(values is null)
                throw new ArgumentNullException(nameof(values));

           if(values.Length is 0)
                Console.WriteLine($"{nameof(values)} is an empty array");

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

        /// <summary>
        /// String array extension for print values
        /// </summary>
        /// <param name="values"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void Dump(this string[] values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            if (values.Length is 0)
                Console.WriteLine($"{nameof(values)} is an empty array");

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

    }
}
