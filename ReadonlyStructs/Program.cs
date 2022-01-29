using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace ReadonlyStructs
{
    public class Program
    {
        static void Main(string[] args)
        {
            "Read-Only Structs".DumpAsTitle();

            EmailConfig yandexConfig = new EmailConfig("smpt.yandex.com", 256, "x@yandex.com", "123*_33sdDF");
            EmailConfig googleConfig = new EmailConfig("smpt.google.com", 25, "x@gmail.com", "123*_33sdDF");

            //Cannot assing a value (read-only) ,to check uncomment
            //yandexConfig.EmailAddress = "y@yandex.com";

            yandexConfig.Display();
            ConsoleHelper.Seperate();
            googleConfig.Display();
        }
    }
}

/// <summary>
/// If a struct is a readonly its required that all the properties must be readonly otherwise complier gives error
/// We can assing readonly variables only in constructor 
/// If we want to assing values of readonly struct need to use default/custom constructor
/// </summary>
readonly struct EmailConfig
{
    //Compiler error ! to check uncomment
    //public string Field_1;
    //public string Property_1 { get; set; }
    public readonly string Server;
    public int Port { get; }
    public string EmailAddress { get; }
    public string Password { get; }

    public EmailConfig(string server,int port,string emailAddress,string password)
    {
        Server = server;
        Port = port;
        EmailAddress = emailAddress;
        Password = password;
    }

    public void Display()
    {
        $"{nameof(Server)} : {Server}".Dump();
        $"{nameof(Port)} : {Port}".Dump();
        $"{nameof(EmailAddress)} : {EmailAddress}".Dump();
        $"{nameof(Password)} : {Password}".Dump();
    }

}
