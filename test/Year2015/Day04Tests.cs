using AdventOfCode.Interfaces;
using AdventOfCode.Providers;
using AdventOfCode.Year2015;

namespace AdventOfCode.Tests.Year2015;

public class Day04Tests
{
  private const string Year = "2015";
  private const string Day = "4";

  private readonly string[] _puzzleInput;
  private readonly ISolution _day04;

  public Day04Tests()
  {
    _puzzleInput = PuzzleInputProvider.GetPuzzleInput(Year, Day);
    _day04 = new Day04();
  }

  [Theory]
  [InlineData("abcdef", 609043, "000001DBBFA3A5C83A2D506429C7B00E")]
  [InlineData("pqrstuv", 1048970, "000006136EF2FF3B291C85725F17325C")]
  public void Part01Examples(string puzzleInput, int answer, string hex)
  {
    var result = _day04.SolvePart1([puzzleInput]);

    Assert.Equal(answer, result);
  }

  [Fact]
  public void Part01()
  {
    var part01Answer = 117946;

    var result = _day04.SolvePart1(_puzzleInput);

    Assert.Equal(part01Answer, result);
  }

  [Fact]
  public void Part02()
  {
    var part02Answer = 3938038;

    var result = _day04.SolvePart2(_puzzleInput);

    Assert.Equal(part02Answer, result);
  }
}