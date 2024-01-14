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
