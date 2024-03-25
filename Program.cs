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