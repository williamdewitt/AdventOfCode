namespace AdventOfCode.Providers;

public class PuzzleInputProvider
{
  public static string[] GetPuzzleInput(string year, string day)
  {
    var path = Path.Join(Environment.CurrentDirectory, "PuzzleInput", year, $"{day.PadLeft(2, '0')}.txt");
    if (!File.Exists(path))
    {
      throw new FileNotFoundException($"Puzzle input file not found: {path}");
    }

    return File.ReadAllLines(path);
  }
}