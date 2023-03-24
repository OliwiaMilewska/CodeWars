using System.Collections.Generic;
using System.Linq;
using System;

public class Program
{
  public static string SpinWords(string sentence)
  {
    var words = sentence.Split(" ");
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length >= 5)
        {
            char[] array = words[i].ToCharArray();
            Array.Reverse(array);
            words[i] = new string(array);
        }
    }

    return string.Join(" ", words); ;
  }
}