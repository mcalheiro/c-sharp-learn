// Lists
using System.Diagnostics;

var names = new List<string> {"Ana", "Bruno", "Carlos"};
// List<string> = new List<string> -> This is also fine but there's a lot repeated code.

foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("\n");
names.Add("Daniel");
names.Add("Ester");
names.Add("Felipe");

// Checking the last value
Console.WriteLine($"Last name is {names[^1]}");

// Checking a range [inclusive..exclusive]
foreach (var name in names[2..4])
{
    Console.WriteLine(name.ToUpper());
}

// Arrays
Console.WriteLine("\n");

var otherNames = new string[] {"Ana", "Bruno", "Carlos"};

foreach (var name in otherNames)
{
    Console.WriteLine(name);
}

otherNames = [..names, "Daniel"];

foreach (var name in otherNames)
{
    Console.WriteLine(name);
}