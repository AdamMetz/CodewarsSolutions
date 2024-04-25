/*

Scramblies (https://www.codewars.com/kata/55c04b4cc56a697bb0000048/train/csharp)

Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

*/

using System;
using System.Linq;
using System.Collections.Generic;

public class Scramblies 
{
    public static bool Scramble(string str1, string str2) 
    {
        List<char> remainingChars = str2.ToList();
      
        foreach (char c in str1) {
          remainingChars.Remove(c);
        }
      
        return remainingChars.Count == 0;
    }
}
