// LINQ

using System.ComponentModel;

List<int> scores = [97, 92, 81, 60];

IEnumerable<int> scoreQuery = 
    from score in scores 
    where score > 80
    orderby score ascending
    select score;

foreach (var score in scoreQuery)
{
    Console.Write($"{score} ");
}

// LINQ with strings
IEnumerable<string> scoreStringsQuery =
    from score in scores
    where score > 80
    orderby score descending
    select $"Score: {score}";

foreach (var s in scoreStringsQuery)
{
    Console.WriteLine(s);
}

// Counting with LINQ
IEnumerable<int> highScores =
    from score in scores
    where score > 80
    select score;

Console.WriteLine(highScores.Count());