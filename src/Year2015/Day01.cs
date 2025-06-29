using AdventOfCode.Interfaces;

namespace AdventOfCode.Year2015;

public class Day01 : ISolution
{
  private const int Basement = -1;

  private int _floor = 0;

  public int SolvePart1(string[] input)
  {
    var puzzleInput = input.First().ToCharArray();

    puzzleInput.ToList().ForEach(direction =>
    {
      if (direction == '(')
        _floor++;
      else if (direction == ')')
        _floor--;
    });

    return _floor;
  }

  public int SolvePart2(string[] input)
  {
    var puzzleInput = input.First().ToCharArray();

    int position = 0;

    foreach (var direction in puzzleInput)
    {
      if (direction == '(')
      {
        _floor++;
        position++;
      }
      else if (direction == ')')
      {
        _floor--;
        position++;
      }

      if (_floor == Basement)
      {
        break; // Exit the loop early when the basement is reached
      }
    }

    return position;
  }
}
