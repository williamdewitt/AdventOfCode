using AdventOfCode.Interfaces;
using AdventOfCode.Providers;
using AdventOfCode.Year2015;

namespace AdventOfCode.Tests.Year2015;

public class Day02Tests
{
  private const string Year = "2015";
  private const string Day = "2";

  private readonly string[] _puzzleInput;
  private readonly ISolution _day02;

  public Day02Tests()
  {
    _puzzleInput = PuzzleInputProvider.GetPuzzleInput(Year, Day);
    _day02 = new Day02();
  }

  [Fact]
  public void Part01()
  {
    var part01Answer = 1598415;

    var result = _day02.SolvePart1(_puzzleInput);

    Assert.Equal(part01Answer, result);
  }

  [Fact]
  public void Part02()
  {
    var part02Answer = 3812909;

    var result = _day02.SolvePart2(_puzzleInput);

    Assert.Equal(part02Answer, result);
  }
}