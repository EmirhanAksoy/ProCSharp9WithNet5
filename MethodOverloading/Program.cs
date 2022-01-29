using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Method Overloading".DumpAsTitle();


            Email.SendEmail("Me", "Loki");
            Email.SendEmail("Me", "Loki", "Hey there !");
            Email.SendEmail("Me", "Loki", "Hey there !", new string[] { "Water", "Cat Food", "Cat Sand" });
            Email.SendEmail("Me", "Loki", "Hey there !", new string[] { "Water", "Cat Food", "Cat Sand" }, new string[] { "Borc" });
            Email.SendEmail("Me", "Loki", "Hey there !", new string[] { "Water", "Cat Food", "Cat Sand" }, new string[] { "Borc" }, new string[] { "Lokum" });

            $"IMPORTANT NOTE :".Dump();
            $"The following example cause an error.Compiler is not able to find differ for parameter modifiers".Dump();
            $"static int Add(ref int x)".Dump();
            $"static int Add(ref int y)".Dump();
            $"-----------------".Dump();
            $"The following example is OK.Compiler can distinguish between the signatures".Dump();
            $"static int Add(ref int x)".Dump();
            $"static int Add(int x)".Dump();

        }
    }
}



/// <summary>
/// We can use same method name with different number/type parameters which is called OVERLOADING
/// </summary>
public static class Email
{
    public static void SendEmail(string from, string to)
    {
        $"FROM: {from}".Dump();
        $"TO: {to}".Dump();
        ConsoleHelper.Seperate();
    }

    public static void SendEmail(string from, string to, string content)
    {
        $"FROM: {from}".Dump();
        $"TO: {to}".Dump();
        $"CONTENT: {content}".Dump();
        ConsoleHelper.Seperate();
    }

    public static void SendEmail(string from, string to, string content, string[] attachments)
    {
        $"FROM: {from}".Dump();
        $"TO: {to}".Dump();
        $"CONTENT: {content}".Dump();
        $"ATTACHMENTS: {attachments}".Dump();
        ConsoleHelper.Seperate();
    }

    public static void SendEmail(string from, string to, string content, string[] attachments, string[] CC)
    {
        $"FROM: {from}".Dump();
        $"TO: {to}".Dump();
        $"CONTENT: {content}".Dump();
        $"ATTACHMENTS: {attachments}".Dump();
        $"CC: {CC}".Dump();
        ConsoleHelper.Seperate();
    }

    public static void SendEmail(string from, string to, string content, string[] attachments, string[] CC, string[] BCC)
    {
        $"FROM: {from}".Dump();
        $"TO: {to}".Dump();
        $"CONTENT: {content}".Dump();
        $"ATTACHMENTS: {attachments}".Dump();
        $"CC: {CC}".Dump();
        $"BCC: {CC}".Dump();
        ConsoleHelper.Seperate();
    }

}

/// <summary>
/// Another example for method overloading
/// The following example can be written more concisely with a generic list.
/// </summary>
public static class Calculate
{
    public static int Sum(int x, int y) => x + y;
    public static int Sum(int x, int y, int initalValue) => initalValue + x + y;

    public static double Sum(double x, double y) => x + y;
    public static double Sum(double x, double y, double initalValue) => initalValue + x + y;

    public static float Sum(float x, float y) => x + y;
    public static float Sum(float x, float y, float initalValue) => initalValue + x + y;
}


