// OOP
var p1 = new Person("Joao", "Maia", new DateOnly(1980, 1, 1));
var p2 = new Person("Maria", "Bunita", new DateOnly(1990, 1, 1));

List<Person> people = [p1, p2];
Console.WriteLine(people.Count);

// Adding pets to people
p1.Pets.Add(new Dog("Scooby"));
p2.Pets.Add(new Cat("Oliver"));
p2.Pets.Add(new Cat("Doraemon"));

foreach(var person in people)
{
    Console.WriteLine(person); 
    foreach(var pet in person.Pets)
    {
        Console.WriteLine($"Has {pet}");
    }
}

// Creating a class
class Person(string firstName, string lastName, DateOnly birthday)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public DateOnly Birthday { get; } = birthday;
    public List<Pet> Pets { get; } = new();
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

public abstract class Pet(string name)
{
    public string PetName { get; } = name;

    public abstract string MakeNoise();
    public override string ToString()
    {
        return $"{PetName}, a {GetType().Name.ToLower()}";
    }
}

public class Cat(string name) : Pet(name)
{

    public string Name { get; } = name;
    public override string MakeNoise()
    {
        return "Meow";
    }
}

public class Dog(string name) : Pet(name)
{
    public string Name { get; } = name;

    public override string MakeNoise()
    {
        return "Bark";
    }
}