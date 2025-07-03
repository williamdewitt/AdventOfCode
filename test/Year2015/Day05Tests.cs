using AdventOfCode.Interfaces;
using AdventOfCode.Providers;
using AdventOfCode.Year2015;

namespace AdventOfCode.Tests.Year2015;

public class Day05Tests
{
  private const string Year = "2015";
  private const string Day = "5";

  private readonly string[] _puzzleInput;
  private readonly ISolution _day05;

  public Day05Tests()
  {
    _puzzleInput = PuzzleInputProvider.GetPuzzleInput(Year, Day);
    _day05 = new Day05();
  }

  [Theory]
  [InlineData("ugknbfddgicrmopn", 1)]
  [InlineData("aaa", 1)]
  [InlineData("jchzalrnumimnmhp", 0)]
  [InlineData("haegwjzuvuyypxyu", 0)]
  [InlineData("dvszwmarrgswjxmb", 0)]
  public void Part01Examples(string puzzleInput, int answer)
  {
    var result = _day05.SolvePart1([puzzleInput]);

    Assert.Equal(answer, result);
  }

  [Fact]
  public void Part01()
  {
    var part01Answer = 258;

    var result = _day05.SolvePart1(_puzzleInput);

    Assert.Equal(part01Answer, result);
  }

  [Theory]
  [InlineData("qjhvhtzxzqqjkmpb", 1)]
  [InlineData("xxyxx", 1)]
  [InlineData("uurcxstgmygtbstg", 0)]
  [InlineData("ieodomkazucvgmuy", 0)]
  public void Part02Examples(string puzzleInput, int answer)
  {
    var result = _day05.SolvePart2([puzzleInput]);

    Assert.Equal(answer, result);
  }

  [Fact]
  public void Part02()
  {
    var part02Answer =53;

    var result = _day05.SolvePart2(_puzzleInput);

    Assert.Equal(part02Answer, result);
  }
}