// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Strings
string firstPerson = "Maria";
string secondPerson = "John";
Console.WriteLine($"Their names are {firstPerson} and {secondPerson}");

// String.Trim
string spacedName = "       Hi there       ";
Console.WriteLine($"No trim: {spacedName}");
Console.WriteLine($"TrimStart: {spacedName.TrimStart()}");
Console.WriteLine($"TrimEnd: {spacedName.TrimEnd()}");
Console.WriteLine($"Trim: {spacedName.Trim()}");

// String.Replace
string names = $"Their names are {firstPerson} and {secondPerson}";
Console.WriteLine(names.Replace("John", "Marco"));
Console.WriteLine(names);

// String.Contain
Console.WriteLine(names.Contains("Maria"));
Console.WriteLine(names.Contains("Julian"));

// Formatting and length
Console.WriteLine(names.ToUpper());
Console.WriteLine(names.ToLower());
Console.WriteLine(names.Length);