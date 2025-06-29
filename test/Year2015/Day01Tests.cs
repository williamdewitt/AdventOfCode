using AdventOfCode.Interfaces;
using AdventOfCode.Providers;
using AdventOfCode.Year2015;

namespace AdventOfCode.Tests.Year2015;

public class Day01Tests
{
  private readonly string[] _puzzleInput;
  private const string Year = "2015";
  private const string Day = "01";

  private readonly ISolution _day01;

  public Day01Tests()
  {
    _puzzleInput = PuzzleInputProvider.GetPuzzleInput(Year, Day);
    _day01 = new Day01();
  }

  [Fact]
  public void Part01()
  {
    var part01Answer = 232;
    var puzzleInputDay01 = _puzzleInput;

    var result = _day01.SolvePart1(puzzleInputDay01);

    Assert.Equal(part01Answer, result);
  }

  [Fact]
  public void Part02()
  {
    var part02Answer = 1783;
    var puzzleInputDay01 = _puzzleInput;

    var result = _day01.SolvePart2(puzzleInputDay01);

    Assert.Equal(part02Answer, result);
  }
}