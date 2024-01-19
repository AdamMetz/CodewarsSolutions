/*

Playing With Digits (https://www.codewars.com/kata/5552101f47fc5178b1000050/train/csharp)

Some numbers have funny properties. For example:

89 --> 8¹ + 9² = 89 * 1
695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2
46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51
Given two positive integers n and p, we want to find a positive integer k, if it exists, such that the sum of the digits of n raised to consecutive powers starting from p is equal to k * n.

Note: n and p will always be strictly positive integers.

*/

using System;

public class DigPow {
	public static long digPow(int n, int p) {
    int numberOfDigits = (int)Math.Floor(Math.Log10(n) + 1); 
    int number = n;
    int sum = 0;
		for (int i = 0; i < numberOfDigits; i++) {
      int digit = number % 10;
      sum += (int)Math.Pow(digit, p + numberOfDigits - i - 1);
      number /= 10;
    }
    int k = sum / n;
    if (k * n == sum) return k;
    return -1;
	}
}
