using AdventOfCode.Interfaces;
using AdventOfCode.Providers;
using AdventOfCode.Year2015;

namespace AdventOfCode.Tests.Year2015;

public class Day03Tests
{
  private const string Year = "2015";
  private const string Day = "3";

  private readonly string[] _puzzleInput;
  private readonly ISolution _day03;

  public Day03Tests()
  {
    _puzzleInput = PuzzleInputProvider.GetPuzzleInput(Year, Day);
    _day03 = new Day03();
  }

  [Fact]
  public void Part01()
  {
    var part01Answer = 2572;

    var result = _day03.SolvePart1(_puzzleInput);

    Assert.Equal(part01Answer, result);
  }

  [Fact]
  public void Part02()
  {
    var part02Answer = 2631;

    var result = _day03.SolvePart2(_puzzleInput);

    Assert.Equal(part02Answer, result);
  }
}