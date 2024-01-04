/*

Find the odd int (https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp)

Given an array of integers, find the one that appears an odd number of times.

There will always be only one integer that appears an odd number of times.

*/

using System;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        Array.Sort(seq);
        int numOccurences = 0;
        int prevNum = seq[0];
        foreach (int num in seq) {
          if (num == prevNum) {
            numOccurences += 1;
            continue;
          }
          if (numOccurences % 2 == 1) return prevNum;
          prevNum = num;
          numOccurences = 1;
        }
        return seq[seq.Length - 1];
      }
    }
}
