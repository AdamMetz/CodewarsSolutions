/*

Split Strings (https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/train/csharp)

Complete the solution so that it splits the string into pairs of two characters. 
If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

*/

using System;

public class SplitString
{
  public static string[] Solution(string str)
  {
    int arrayLength = (int)Math.Ceiling((double)str.Length / 2);
    string[] splitStr = new string[arrayLength];
    for (int i = 0; i < str.Length; i += 2) {
      // Check if theres at least 2 characters prior between the current index and end of the string
      if (i + 1 < str.Length) {
        splitStr[i / 2] = str.Substring(i, 2);
      // Otherwise, add the final character in the string alongside an "_"
      } else {
        splitStr[i / 2] = str[i] + "_";
      }
    }
    return splitStr;
  }
}
