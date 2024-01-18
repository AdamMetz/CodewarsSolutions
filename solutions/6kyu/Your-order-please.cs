/*

Your order, please (https://www.codewars.com/kata/55c45be3b2079eccff00010f/train/csharp)

Your task is to sort a given string. Each word in the string will contain a single number. 
This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

*/

using System;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Order(string words)
  {
    if (words == "") return words;
    string[] splitWords = words.Split(" ");
    string[] orderedWords = new string[splitWords.Length];
    foreach (string word in splitWords) {
      int orderedPosition = Convert.ToInt32(Regex.Match(word, "\\d").Value) - 1;
      orderedWords[orderedPosition] = word;
    }
    return String.Join(" ", orderedWords);
  }
}
