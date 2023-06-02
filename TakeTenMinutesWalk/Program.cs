using System.Linq;

public class Program
{
  public static bool IsValidWalk(string[] walk)
  {
    return walk.Length == 10 && walk.Count(x => x == "n") == walk.Count(x => x == "s") && walk.Count(x => x == "e") == walk.Count(x => x == "w"); 
  }
}