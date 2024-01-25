/*

Build Tower (https://www.codewars.com/kata/576757b1df89ecf5bd00073b/train/csharp)

Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. A tower block is represented with "*" character.

*/

public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    string[] floors = new string[nFloors];
    int towerWidth = 2*nFloors - 1;
    for (int i = 0; i < nFloors; i++) {
      int numberOfAsterisks = 2*i + 1;
      int numberOfSpaces = (towerWidth - numberOfAsterisks) / 2; 
      floors[i] = $"{new string(' ', numberOfSpaces)}{new string('*', numberOfAsterisks)}{new string(' ', numberOfSpaces)}";
    }
    return floors;
  }
}
