using AdventOfCode.Interfaces;

namespace AdventOfCode.Year2015;

public class Day02 : ISolution
{
  public int SolvePart1(string[] input)
  {
    var total = 0;

    input.ToList().ForEach(input =>
    {
      var dimensions = input.Split('x').Select(int.Parse).ToArray();

      var surfaces = CalculateSurfaces(dimensions[0], dimensions[1], dimensions[2]);
      var salck = surfaces.Order().First() / 2; // Devide by two to get one side.
      var subTotal = surfaces[0] + surfaces[1] + surfaces[2] + salck;

      total += subTotal;
    });

    return total;
  }

  public int SolvePart2(string[] input)
  {
    var totalRibbonLength = 0;

    input.ToList().ForEach(present =>
    {
      var dimentions = present.Split('x').Select(int.Parse).Order().ToArray();

      var ribbonLength = GetRibbonLength(dimentions);

      totalRibbonLength += ribbonLength;

    });

    return totalRibbonLength;
  }

  private static int[] CalculateSurfaces(int length, int width, int height)
  {
    var sideA = 2 * length * width;
    var sideB = 2 * width * height;
    var sideC = 2 * height * length;

    return [sideA, sideB, sideC];
  }

  private static int GetRibbonLength(int[] dimentions)
  {
    var ribbonLength = dimentions[0] * 2 + dimentions[1] * 2;
    var bowRibbonLength = dimentions[0] * dimentions[1] * dimentions[2];

    return ribbonLength + bowRibbonLength;
  }
}