using AdventOfCode.Interfaces;

namespace AdventOfCode.Year2015;

public class Day03 : ISolution
{
  public int SolvePart1(string[] input)
  {
    int[] startingHouse = [0, 0];
    var houses = new Dictionary<string, int>();
    var directions = input.First().ToCharArray();

    houses.Add(string.Join(',', startingHouse), 1);

    directions.ToList().ForEach(direction =>
    {
      switch (direction)
      {
        case '>':
          startingHouse[1]++;
          break;
        case '<':
          startingHouse[1]--;
          break;
        case '^':
          startingHouse[0]++;
          break;
        case 'v':
          startingHouse[0]--;
          break;
        default:
          break;
      }

      houses.TryAdd(string.Join(',', startingHouse), 1);
    });

    return houses.Count;
  }

  public int SolvePart2(string[] input)
  {
    int[] startingHouse = [0, 0];
    var houses = new Dictionary<string, int>();
    var directions = input.First().ToCharArray();

    houses.Add(string.Join(',', startingHouse), 1);

    for (int i = 0; i < directions.Length; i += 2)
    {
      switch (directions[i])
      {
        case '>':
          startingHouse[1]++;
          break;
        case '<':
          startingHouse[1]--;
          break;
        case '^':
          startingHouse[0]++;
          break;
        case 'v':
          startingHouse[0]--;
          break;
        default:
          break;
      }

      houses.TryAdd(string.Join(',', startingHouse), 1);
    }

    startingHouse = [0, 0];

    for (int i = 1; i < directions.Length; i += 2)
    {
      switch (directions[i])
      {
        case '>':
          startingHouse[1]++;
          break;
        case '<':
          startingHouse[1]--;
          break;
        case '^':
          startingHouse[0]++;
          break;
        case 'v':
          startingHouse[0]--;
          break;
        default:
          break;
      }

      houses.TryAdd(string.Join(',', startingHouse), 1);
    }

    return houses.Count;
  }
}