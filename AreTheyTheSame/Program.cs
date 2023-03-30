using System;
using System.Linq;

public class Program
{
  public static bool comp(int[] a, int[] b)
  {
    if (a == null || b == null || a.Length != b.Length) return false;
    var powerA = a.Select(x => (int)Math.Pow(x, 2)).ToList();
    powerA.Sort();
    var sortB = b.ToList();
    sortB.Sort();
    return powerA.SequenceEqual(sortB);
  }
}