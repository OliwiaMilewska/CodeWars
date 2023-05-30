using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static int[] MoveZeroes(int[] arr)
  {
    // First attempt
    /*var result = new List<int>();
    result = arr.Where(x => x != 0).ToList();
    for (int i = 0; i < arr.Length - result.Count; i++)
        result.Add(0);
    return result.ToArray();*/
    
    // Shorter version 
    return arr.OrderBy(x => x == 0).ToArray();
  }
}