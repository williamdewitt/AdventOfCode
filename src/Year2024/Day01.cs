namespace AdventOfCode.Year2024;

public class Day01
{
  public static int SolvePart1(string[] input)
  {
    var puzzleInput = input.ToList();
    var leftValues = new List<int>();
    var rightValues = new List<int>();

    puzzleInput.ForEach(i => 
    {
      var split = i.Split("   ");
      leftValues.Add(int.Parse(split[0]));
      rightValues.Add(int.Parse(split[1]));
    });

    leftValues = leftValues.Order().ToList();
    rightValues = rightValues.Order().ToList();

    var total = 0;

    for(var i = 0; i < puzzleInput.Count; i++)
    {
      total += Math.Abs(leftValues[i] - rightValues[i]);
    }

    return total;
  }

  public static int SolvePart2(string[] input)
  {
    var puzzleInput = input.ToList();
    var leftValues = new List<int>();
    var rightValues = new List<int>();

    puzzleInput.ForEach(i => 
    {
      var split = i.Split("   ");
      leftValues.Add(int.Parse(split[0]));
      rightValues.Add(int.Parse(split[1]));
    });

    var total = 0;

    for(var i = 0; i < puzzleInput.Count; i++)
    {
      var occurences = rightValues.Where(x => x == leftValues[i]);
      total += leftValues[i] * occurences.Count();
    }

    return total;
  }
}
