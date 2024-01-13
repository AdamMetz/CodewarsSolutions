/* 

Persistent Bugger. (https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/train/csharp)

Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

*/

using System;

public class Persist 
{
	public static int Persistence(long n) 
	{
    int persistenceCount = 0;
		while (n >= 10) {
      long sum = 1;
      foreach (char digit in n.ToString()) {
        sum *= (long)Char.GetNumericValue(digit);
      }
      n = sum;
      persistenceCount++;
    }
    return persistenceCount;
	}
}
