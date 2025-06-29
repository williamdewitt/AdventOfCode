
using AdventOfCode;

var puzzleInputDay01 = GetPuzzleInput("2024", "01");
Console.WriteLine($"Day 01 Part 1: {Day01.SolvePart1(puzzleInputDay01)}");
Console.WriteLine($"Day 01 Part 2: {Day01.SolvePart2(puzzleInputDay01)}");

var puzzleInputDay02 = GetPuzzleInput("2024", "02");
Console.WriteLine($"Day 02 Part 1: {Day02.SolvePart1(puzzleInputDay02)}");
Console.WriteLine($"Day 02 Part 2: {Day02.SolvePart2(puzzleInputDay02)}");

static string[] GetPuzzleInput(string year, string day)
{
  var path = Path.Join(Environment.CurrentDirectory, "puzzleInput", year, $"{day.PadLeft(2, '0')}.txt");
  var text = File.ReadAllLines(path);

  return text;
} 