# C#-learning
This repo contains code from [some basic C# training](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oULFjxrOagaERVAMbmG20Xe). C# is a compiled, strongly typed language.

## Requirements
- Install dotnet
- Install C# devkit (in VSCode)

## Start projetc
In terminal, run:
```bash
dotnet new console
```
This will create the necessary files for a basic console project. Then, edit the code in ```Program.cs``` and
```bash
dotnet run
```
to compile and see the results in terminal.

## Strings
Strings are immutable (unless assigned). Using methods such as ```String.Replace``` will return a new string and the original will be intact. Some string methods explored: ```Trim``` and it's variants, ```Replace``` and ```Contain```.

```c#
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
```

## Numbers
**Ints** are stored as 32 bits; **Longs** are stored as 64 bits; **Floats** can be both (float, double). Floats have big range but bad precision. In order to ensure precision, we may use **decimals**.

```c#
// Casting (type)var
int a = 2100000000;
int b = 2100000000;
long c = (long)a + (long)b;
Console.WriteLine(c);

// Floats
double e = 42.1; // Natural type
float f = 7.90F; // Explicit type
Console.WriteLine(e + f);

decimal g = 42.1M; // Natural type
decimal h = 7.90M; // Explicit type
Console.WriteLine(g + h);
```