// Lists
var names = new List<string> {"Ana", "Bruno", "Carlos"};
// List<string> = new List<string> -> This is also fine but there's a lot repeated code.

foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("\n");
names.Add("Daniel");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}