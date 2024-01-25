/*

Sort The Odds (https://www.codewars.com/kata/578aa45ee9fd15ff4600090d/train/csharp)

You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.

*/

using System;
using System.Linq;

public class Kata
{
  public static int[] SortArray(int[] array)
  {
    int[] oddNumbers = array.Where(x => x % 2 == 1).ToArray();
    Array.Sort(oddNumbers);
    int oddNumbersIndex = 0;
    for (int i = 0; i < array.Length; i++) {
      if (array[i] % 2 == 1) {
        array[i] = oddNumbers[oddNumbersIndex];
        oddNumbersIndex++;
      }
    }
    return array;
  }
}
