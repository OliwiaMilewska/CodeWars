using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    return a.Where(x => !b.Contains(x)).ToArray();
  }
}