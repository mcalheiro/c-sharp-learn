// LINQ

List<int> scores = [97, 92, 81, 60];

IEnumerable<int> scoreQuery = 
    from score in scores 
    where score < 80
    select score;

foreach (var score in scoreQuery)
{
    Console.WriteLine(score);
}