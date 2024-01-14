/*

Convert string to camel case (https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp)

Complete the method/function so that it converts dash/underscore delimited words into camel casing. 
The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). 
The next words should be always capitalized.

*/

using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    string result = "";
    for (int i = 0; i < str.Length; i++) {
      result += str[i];
      if (str[i] == '-' || str[i] == '_') {
        result += Char.ToUpper(str[i+1]);
        i++;
      }
    }
    return result.Replace("_", "").Replace("-", "");
  }
}
