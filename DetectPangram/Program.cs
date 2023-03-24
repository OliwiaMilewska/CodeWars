using System;
using System.Linq;

public static class Program
{
  public static bool IsPangram(string str)
  {
     return str.ToLower().Replace(" ", "").Where(x => Char.IsLetter(x)).Distinct().Count() == 26;
  }
}