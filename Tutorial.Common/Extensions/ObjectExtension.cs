using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Common.Extensions
{
    public static class ObjectExtension
    {
        /// <summary>
        /// Object extension for print value
        /// </summary>
        /// <param name="value"></param>
        public static void Dump(this object value)
        {
            Console.WriteLine($"     {value}");
            Console.WriteLine();
        }

        /// <summary>
        /// Object extension for print value
        /// </summary>
        /// <param name="value"></param>
        public static void DumpAsTitle(this object value)
        {
            Console.WriteLine();
            Console.WriteLine($"***     {value}     ***");
            Console.WriteLine();
        }
    }
}
