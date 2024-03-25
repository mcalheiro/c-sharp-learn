# C# practice
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

## Branching
Creating an if in C# is easy. Just do:
```c#
if (condition) {
    // Your code here
    ...
}
``` 
We may also and else statements and nest if necessary,
```c#
int a = 5;
int b = 6;

if (a + b > 10)
{
    Console.WriteLine("Yes, it is");
} 
else
{
    Console.WriteLine("No, it's not");
}

// Booleans
bool myTest = a + b > 10;

if (myTest)
{
    Console.WriteLine(a + b);
}

// AND: &&, OR: ||
if (myTest && a == b)
{
    Console.WriteLine("a == b");
} 
else
{
    Console.WriteLine("a != b");
}
```

## Loops
A **while** loop is as simple as:
```c#
while (condition)
{
    // Your code here
    ...
}
```
there is also **do**, in order to run the code at least once before checking the condition
```c#
do
{
    // Your code here
    ...
} while (condition);
```

Here are some simple examples:
```c#
// While loops
int counter = 0;

while (counter < 10)
{
    Console.WriteLine(counter);
    counter++;
}

//Do-while
do
{
    Console.WriteLine($"The next value is {counter}");
} while (false);
```

**For** loops are the best, right? Here it is similar to standard C. Here's how to do it
```c#
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

## Lists and collections
List<T> is way to much typing but what can I do?
```c#
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
```

Arrays are fixed in length. We may change the content of the original data, but we cannot add or remove elements.

```c#
// Arrays
Console.WriteLine("\n");

var otherNames = new string[] {"Ana", "Bruno", "Carlos"};
foreach (var name in otherNames)
{
    Console.WriteLine(name);
}
```

In order to add elements, we must make a new array with the contents of the original and append the new data.

```c#
// Create a new array and add a name to it
otherNames = [..otherNames, "Daniel"];
```

## Sorting and searching
Sorting a list will change the original list to return the sorted version. Most methods that return nothing (```void```) will modify the original element.
```c#
// Sorting
var names = new List<string> {
    "Zoro", "Luffy", 
    "Sanji", "Brook", 
    "Chopper", "Usopp",
    "Robin", "Nami",
    "Franky", "Jinbe"};

names.Sort();

foreach (var name in names)
{
    Console.WriteLine(name);
}

// Searching
var nums = new List<int> { 1, 0, -3, 100, 76, -56 };
Console.WriteLine(nums.IndexOf(-56));
nums.Sort();
Console.WriteLine(nums.IndexOf(-56));
```

## LINQ: Language Integrated Query
This is a SQL-like way of filtering data. Pretty cool. Imperative programming. Given a data source, we can use an enumerable to fetch the data that corresponds to some criteria.
```c#
// LINQ

List<int> scores = [97, 92, 81, 60]; // Data source

IEnumerable<int> scoreQuery = 
    from score in scores 
    where score < 80
    select score;

foreach (var score in scoreQuery)
{
    Console.WriteLine(score);
}
```