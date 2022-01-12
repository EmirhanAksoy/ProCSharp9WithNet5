using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Common.Helper
{
    public static class ConsoleHelper
    {
        /// <summary>
        /// Creates seperation in Console UI
        /// </summary>
        public static void Seperate()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// Frames the given value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="title"></param>
        public static void Frame(object value,string title = "")
        {
            Console.WriteLine($"------------------------{title}-----------------------------");
            Console.WriteLine($"{value}");
            Console.WriteLine($"------------------------{title}-----------------------------");
        }
    }
}
