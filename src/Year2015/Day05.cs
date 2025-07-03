using AdventOfCode.Interfaces;
using System.Text.RegularExpressions;

namespace AdventOfCode.Year2015;

public class Day05 : ISolution
{
  public int SolvePart1(string[] input)
  {
    var niceCount = 0;

    input.ToList().ForEach(item =>
    {
      if (IsNiceV1(item))
      {
        niceCount++;
      }
    });

    return niceCount;
  }

  public int SolvePart2(string[] input)
  {
    var niceCount = 0;

    input.ToList().ForEach(item =>
    {
      if (IsNiceV2(item))
      {
        niceCount++;
      }
    });

    return niceCount;
  }

  private static bool IsNiceV1(string item)
  {
    List<string> naughtyStrings = ["ab", "cd", "pq", "xy"];

    var passedVoulCount = false;
    var passedDoubleChar = false;
    var hasNaughtyStrings = false;

    var voulCount = item.Count(c => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
    if (voulCount >= 3) passedVoulCount = true;

    for (int i = 0; i < item.Length - 1; i++)
    {
      if (item[i] == item[i + 1])
      {
        passedDoubleChar = true;
        break;
      }
    }

    naughtyStrings.ForEach(n =>
    {
      if (item.Contains(n)) hasNaughtyStrings = true;
    });

    return passedVoulCount && passedDoubleChar && !hasNaughtyStrings;
  }

  private static bool IsNiceV2(string item)
  {
    var rule1 = false;
    var rule2 = false;

    for (int i = 0; i < item.Length - 2; i++)
    {
      var part1 = string.Concat(item.Skip(i).Take(1));
      var part2 = string.Concat(item.Skip(i + 2).Take(1));

      if (part1 == part2) rule1 = true;
    }

    for (int i = 0; i < item.Length - 2; i++)
    {
      var pair = string.Concat(item.Skip(i).Take(2));
      var pairCount = 0;

      for (int j = 0; j < item.Length - 1; j++)
      {
        var tempPair = string.Concat(item.Skip(j).Take(2));
        if (pair == tempPair)
        {
          if (Math.Abs(j - i) >= 2 || j - i == 0)
          {
            pairCount++;
          }
        }

        if (pairCount > 1)
        {
          rule2 = true;
          i = item.Length;
          j = item.Length;
        }
      }
    }

    return rule1 && rule2;
  }
}