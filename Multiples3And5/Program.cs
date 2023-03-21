using System.Collections.Generic;
using System.Linq;
public static class Program
{
  public static int Solution(int value)
  {
    if (value < 0) return 0;

    HashSet<int> threeAndFive = new HashSet<int>();
    int pom3 = 0;
    int pom5 = 0;
    while (pom3 < value)
    {
        if(pom3 < value) threeAndFive.Add(pom3);
        pom3 += 3;
    }
    while (pom5 < value)
    {
        if (pom5 < value) threeAndFive.Add(pom5);
        pom5 += 5;
    }
    
    return threeAndFive.Sum(x => x);
  }
}