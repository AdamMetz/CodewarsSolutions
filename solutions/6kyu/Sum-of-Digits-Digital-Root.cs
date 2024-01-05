/*
Sum of Digits / Digital Root (https://www.codewars.com/kata/541c8630095125aba6000c00/train/csharp)

Digital root is the recursive sum of all the digits in a number.

Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.

*/

using System;

public class Number
{
  public static int DigitalRoot(long n)
  {
    string nStr = n.ToString();
    int sum = 0;
    do {
      sum = 0;
      foreach (char digit in nStr) {
        sum += (int)Char.GetNumericValue(digit);
      }
      nStr = sum.ToString();
    } while (nStr.Length > 1);
    return sum;
  }
}
