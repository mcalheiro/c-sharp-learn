// Branching, conditions

int a = 5;
int b = 6;

if (a + b > 10) {
    Console.WriteLine("Yes, it is");
} else {
    Console.WriteLine("No, it's not");
}

// Booleans
bool myTest = a + b > 10;

if (myTest) {
    Console.WriteLine(a + b);
}

// AND: &&, OR: ||
if (myTest && a == b) {
    Console.WriteLine("a == b");
} else {
    Console.WriteLine("a != b");
}