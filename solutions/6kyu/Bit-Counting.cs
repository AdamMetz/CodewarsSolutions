/*

Bit Counting (https://www.codewars.com/kata/526571aae218b8ee490006f4/train/csharp)

Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. You can guarantee that input is non-negative.

*/

using System;

public class Kata
{
  public static int CountBits(int n)
  {
    int count = 0;
    while (n > 0){
      if ((n & 1) == 1) {
        count++;
      }
      n = n>>1;
    }
    return count;
  }
}
