using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        /// <summary>
        /// Get object memory address
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetObjectAddress(object obj)
        {
            GCHandle objHandle = GCHandle.Alloc(obj, GCHandleType.WeakTrackResurrection);
            var pointer = GCHandle.ToIntPtr(objHandle);
            objHandle.Free();

            return "0x" + pointer.ToString("X");
        }
    }
}
