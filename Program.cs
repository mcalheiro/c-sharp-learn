// OOP
var p1 = new Person("Joao", "Maia", new DateOnly(1980, 1, 1));
var p2 = new Person("Maria", "Maia", new DateOnly(1990, 1, 1));

List<Person> people = [p1, p2];
Console.WriteLine(people.Count);

// Creating a class
class Person(string firstName, string lastName, DateOnly birthday)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public DateOnly Birthday { get; } = birthday;
}
