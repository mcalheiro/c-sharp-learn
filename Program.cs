// LINQ
List<int> scores = [97, 92, 81, 60];
var scoreQuery = scores.Where(s => s > 80).Sum();
Console.WriteLine(scoreQuery);