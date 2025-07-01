using AdventOfCode.Interfaces;
using System.Security.Cryptography;

namespace AdventOfCode.Year2015;

public class Day04 : ISolution
{
  public int SolvePart1(string[] input)
  {
    for (int i = 0; i < int.MaxValue; i++)
    {
      byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input.First() + i.ToString());
      byte[] hashBytes = MD5.HashData(inputBytes);

      var result = Convert.ToHexString(hashBytes);

      if (result.StartsWith("00000"))
      {
        return i;
      }
    }

    return 0;
  }

  public int SolvePart2(string[] input)
  {
    for (int i = 0; i < int.MaxValue; i++)
    {
      byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input.First() + i.ToString());
      byte[] hashBytes = MD5.HashData(inputBytes);

      var result = Convert.ToHexString(hashBytes);

      if (result.StartsWith("000000"))
      {
        return i;
      }
    }

    return 0;
  }
}