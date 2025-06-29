using AdventOfCode.Providers;
using AdventOfCode.Year2024;

namespace AdventOfCode.Tests.Year2024;

public class Day02Tests
{
  private readonly string[] _puzzleInput;
  private const string Year = "2024";
  private const string Day = "02";

  public Day02Tests()
  {
    _puzzleInput = PuzzleInputProvider.GetPuzzleInput(Year, Day);
  }

  [Fact]
  public void Part01()
  {
    var part01Answer = 321;
    var puzzleInputDay02 = _puzzleInput;

    var result = Day02.SolvePart1(puzzleInputDay02);

    Assert.Equal(part01Answer, result);
  }

  [Fact]
  public void Part02()
  {
    var part02Answer = 380;
    var puzzleInputDay02 = _puzzleInput;

    var result = Day02.SolvePart2(puzzleInputDay02);

    Assert.Equal(part02Answer, result);
  }
}