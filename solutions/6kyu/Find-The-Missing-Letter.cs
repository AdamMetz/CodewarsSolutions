/*

Find The Missing Letter (https://www.codewars.com/kata/5839edaa6754d6fec10000a2/train/csharp)

Write a method that takes an array of consecutive (increasing) letters as input and that returns the missing letter in the array.

You will always get an valid array. And it will be always exactly one letter be missing. The length of the array will always be at least 2.
The array will always contain letters in only one case.

*/

using System;

public class Kata
{
  public static char FindMissingLetter(char[] array)
  {
    int prevCharValue = (int)array[0];
    foreach (char c in array) {
      if (prevCharValue + 1 < (int)c) return (char)(prevCharValue + 1);
      prevCharValue = (int)c;
    }
    return 'z';
  }
}
