using System;

// Path

Console.WriteLine(@"C:\Files\RunMe.exe");


string text = @"
                This 
                    is 
                      very
                        strange";

Console.WriteLine(text);


string interpolatedVerbatim = $@"C:\Files\{"My File"}";


Console.WriteLine($"Interpolation verbatim {interpolatedVerbatim}");

Console.WriteLine(@"Single quote 'Emirhan'");
Console.WriteLine(@"Double quote ""Emirhan"" ");







