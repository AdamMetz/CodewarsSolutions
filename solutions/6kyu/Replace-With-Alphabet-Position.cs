/*

Replace With Alphabet Position (https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp)

In this kata you are required to, given a string, replace every letter with its position in the alphabet.

If anything in the text isn't a letter, ignore it and don't return it.

*/

using System;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    string result = "";
    foreach (char c in text) {
      if (char.IsLetter(c)) {
        if (result.Length != 0) result += " ";
        int numericValue = Convert.ToInt32(char.ToUpper(c)) - 64;
        result += numericValue.ToString();
      }
    }
    return result;
  }
}
