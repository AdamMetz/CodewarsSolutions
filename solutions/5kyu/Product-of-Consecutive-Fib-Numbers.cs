/*

Product of consecutive Fib numbers (https://www.codewars.com/kata/5541f58a944b85ce6d00006a/train/csharp)

The Fibonacci numbers are the numbers in the following integer sequence (Fn):

0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...

such as

F(n) = F(n-1) + F(n-2) with F(0) = 0 and F(1) = 1.

Given a number, say prod (for product), we search two Fibonacci numbers F(n) and F(n+1) verifying

F(n) * F(n+1) = prod.

Your function productFib takes an integer (prod) and returns an array:

[F(n), F(n+1), true] or {F(n), F(n+1), 1} or (F(n), F(n+1), True)
depending on the language if F(n) * F(n+1) = prod.

If you don't find two consecutive F(n) verifying F(n) * F(n+1) = prodyou will return

[F(n), F(n+1), false] or {F(n), F(n+1), 0} or (F(n), F(n+1), False)
F(n) being the smallest one such as F(n) * F(n+1) > prod.

*/

using System;
using System.Collections.Generic;

public class ProdFib {
  public static ulong[] productFib(ulong targetProduct) {
    List<ulong> fibonacciSequenceValues = new List<ulong>{0,1};
    int i = 0;
    while (true) {
      ulong currProduct = fibonacciSequenceValues[i] * fibonacciSequenceValues[i+1];
      if (currProduct == targetProduct) {
        return new ulong[] {fibonacciSequenceValues[i], fibonacciSequenceValues[i+1], 1};
      } else if (currProduct > targetProduct) {
        return new ulong[] {fibonacciSequenceValues[i], fibonacciSequenceValues[i+1], 0};
      }
      fibonacciSequenceValues.Add(fibonacciSequenceValues[i] + fibonacciSequenceValues[i+1]);
      i++;
    }
  }
}
