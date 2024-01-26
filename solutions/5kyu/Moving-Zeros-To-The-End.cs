/*

Moving Zeros To The End (https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp)

Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

*/

using System;
using System.Linq;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    int[] nonZeroValues = arr.Where(x => x != 0).ToArray();
    int[] result = new int[arr.Length];
    
    nonZeroValues.CopyTo(result, 0);
    
    for (int i = nonZeroValues.Length; i < result.Length; i++) {
      result[i] = 0;
    }
    
    return result;
  }
}
