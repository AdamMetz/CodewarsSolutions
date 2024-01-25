/*

Highest Scoring Word (https://www.codewars.com/kata/57eb8fcdf670e99d9b000272/train/csharp)

Given a string of words, you need to find the highest scoring word.
Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
For example, the score of abad is 8 (1 + 2 + 1 + 4).
You need to return the highest scoring word as a string.
If two words score the same, return the word that appears earliest in the original string.
All letters will be lowercase and all inputs will be valid.

*/

using System;

public class Kata
{
  public static string High(string s)
  {
    const int ASCII_OFFSET = 96;
    string[] words = s.Split(" ");
    int highScore = -1;
    int highScoreIndex = -1;
    
    for (int i = 0; i < words.Length; i++) {
      int currScore = 0;
      foreach (char letter in words[i]) {
        currScore += (int)letter - ASCII_OFFSET;
      }
      if (currScore > highScore) {
        highScore = currScore;
        highScoreIndex = i;
      }
    }
    return words[highScoreIndex];
  }
}
