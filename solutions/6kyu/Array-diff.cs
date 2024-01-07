/*

Array.diff (https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp)

Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

It should remove all values from list a, which are present in list b keeping their order.

*/

using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    HashSet<int> bValues = new HashSet<int>(b);
    
    List<int> result = new List<int>();
    
    foreach (int num in a) {
      if (!bValues.Contains(num)) {
        result.Add(num);
      }
    }
    return result.ToArray();
  }
}
