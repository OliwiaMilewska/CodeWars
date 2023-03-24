using System;

public static class Program 
{
  public static int TrailingZeros(int n)
  {
    double k = Math.Floor(Math.Log(n, 5));
    int result = 0;
    while(k > 0)
    {
        result += (int)Math.Floor(n / (Math.Pow(5, k)));
        k--;
    }
    return result;
  }
}