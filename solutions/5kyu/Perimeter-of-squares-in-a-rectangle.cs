/*

Perimeter of squares in a rectangle (https://www.codewars.com/kata/559a28007caad2ac4e000083/train/csharp)

The drawing shows 6 squares the sides of which have a length of 1, 1, 2, 3, 5, 8. It's easy to see that the sum of the perimeters of these squares is : 4 * (1 + 1 + 2 + 3 + 5 + 8) = 4 * 20 = 80 

Could you give the sum of the perimeters of all the squares in a rectangle when there are n + 1 squares disposed in the same manner as in the drawing:

*/

using System;
using System.Numerics;

public class SumFct
{
  public static BigInteger perimeter(BigInteger n) 
  {
    BigInteger prevSquareSize = 0;
    BigInteger currSquareSize = 1;
    
    BigInteger perimeterSum = 4 * currSquareSize;
    
    for (int i = 0; i < n; i++) {
      BigInteger nextSquareSize = prevSquareSize + currSquareSize;
      
      perimeterSum += 4 * nextSquareSize;
      
      prevSquareSize = currSquareSize;
      currSquareSize = nextSquareSize;
    }
    
    return perimeterSum;
  }
}
