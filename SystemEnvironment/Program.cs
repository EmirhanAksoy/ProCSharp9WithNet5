using System;


foreach (var drive in Environment.GetLogicalDrives())
{
    Console.WriteLine("Drive : {0}", drive);
}

Console.WriteLine("Operating System : {0}", Environment.OSVersion);
Console.WriteLine("Is 64 BitOperating System : {0}", Environment.Is64BitOperatingSystem);
Console.WriteLine("Processor Count : {0}", Environment.ProcessorCount);
Console.WriteLine(".NET VERSION : {0}", Environment.Version);
Console.WriteLine("Machine Name : {0}", Environment.MachineName);
Console.WriteLine("New Line : {0}", Environment.NewLine);
Console.WriteLine("System Directory : {0}", Environment.SystemDirectory);
Console.WriteLine("Windows User : {0}", Environment.UserName);
Console.WriteLine("User Domain Name : {0}", Environment.UserDomainName);
