/*

First non-repeating character (https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/train/csharp)

Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.

For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.

As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter. 
For example, the input 'sTreSS' should return 'T'.

If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.

*/

using System;
using System.Linq;

public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    var nonRepeatingCharacters = s
      .ToLower()
      .GroupBy(c => c)
      .Where(grp => grp.Count() == 1)
      .Select(grp => grp.Key);
    
    foreach(char c in s){
      if (nonRepeatingCharacters.Contains(Char.ToLower(c))) return c.ToString();
    }
    
    return "";
  }
}
