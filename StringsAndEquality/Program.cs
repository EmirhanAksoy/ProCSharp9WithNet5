using System;

string name = "Emirhan";

string copy = "Emirhan";

// String is a refecerence type but equality depends on its' textual value

Console.WriteLine($"Check with equal method drived from System.Object : {name.Equals(copy)}");

Console.WriteLine($"Check with = operator : {name == copy}");

Console.WriteLine($"Strings are case-sensitive Emirhan && emirhan : { "Emirhan".Equals("emirhan") }");