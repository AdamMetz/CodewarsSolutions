/*

Counting Duplicates (https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp)

Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. 
The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    Dictionary<char, int> charCounts = new Dictionary<char, int>();
  
    foreach (char c in str) {
      char lowerC = char.ToLower(c);
      charCounts[lowerC] = charCounts.GetValueOrDefault(lowerC) + 1;
    }
    
    return charCounts.Count(pair => pair.Value > 1);
  }
}
