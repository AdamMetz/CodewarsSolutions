/*

Directions Reduction (https://www.codewars.com/kata/550f22f4d758534c1100025a/train/csharp)

Write a function dirReduc which will take an array of strings and returns an array of strings with the needless directions removed (W<->E or S<->N side by side).

*/

using System;
using System.Collections.Generic;

public class DirReduction {
  public static string[] dirReduc(String[] arr) {
    List<String> directions = new List<String>(arr);
    int i = 0;
    while (i < directions.Count - 1) {
      if (AreOppositeDirections(directions[i], directions[i+1])) {
        directions.RemoveRange(i, 2);
        i = Math.Max(0, i-1);
        continue;
      }
      i += 1;
    }
    return directions.ToArray();
  }
  
  private static bool AreOppositeDirections(string dir1, string dir2) {
      return (dir1 == "NORTH" && dir2 == "SOUTH") || 
             (dir1 == "SOUTH" && dir2 == "NORTH") || 
             (dir1 == "EAST" && dir2 == "WEST") || 
             (dir1 == "WEST" && dir2 == "EAST");
  }
}
