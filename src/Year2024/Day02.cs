namespace AdventOfCode.Year2024;

public class Day02
{
  public static int SolvePart1(string[] input)
  {
    var puzzleInput = input.ToList();
    var answer = 0;
    foreach(var line in puzzleInput)
    {
      var report = line.Split(' ')
                      .Select(x => int.Parse(x))
                      .ToList();

      if(IsSafe(report))
      {
        answer++;
      }
    }

    return answer;
  }

  public static int SolvePart2(string[] input)
  {
    var puzzleInput = input.ToList();
    var answer = 0;

    foreach(var line in puzzleInput)
    {
      var report = line.Split(' ')
                      .Select(x => int.Parse(x))
                      .ToList();

      if(IsSafeV2(report))
      {
        answer++;
      }
    }

    return answer;
  }

  static bool IsSafe(List<int> report)
  {
    var isIncreasing = false;

    if(report[1] > report[0])
    {
      isIncreasing = true;
    }

    for(var i = 0; i < report.Count() -1; i++)
    {
      var value = report[i] - report[i + 1];

      if(value == 0 || Math.Abs(value) > 3)
      {
        return false;
      }

      if(isIncreasing)
      {
        if(report[i] > report[i + 1])
        {
          return false;
        }
      }
      else
      {
        if(report[i] < report[i + 1])
        {
          return false;
        }
      }
    }

    return true;
  }

  static bool IsSafeV2(List<int> report)
  {
    var isIncreasing = false;
  var unsafeResults = 0;

  if(report[1] > report[0])
  {
    isIncreasing = true;
  }

  for(var i = 0; i < report.Count() -1; i++)
  {
    var value = report[i] - report[i + 1];

    if(value == 0 || Math.Abs(value) > 3)
    {
      unsafeResults ++;
    }

    if(isIncreasing)
    {
      if(report[i] > report[i + 1])
      {
        unsafeResults++;
      }
    }
    else
    {
      if(report[i] < report[i + 1])
      {
        unsafeResults++;
      }
    }
  }

  if(unsafeResults > 1)
  {
    return false;
  }

  return true;
  }
}

