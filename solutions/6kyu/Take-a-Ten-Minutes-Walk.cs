/*

Take a Ten Minutes Walk (https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp)

You live in the city of Cartesia where all roads are laid out in a perfect grid. You arrived ten minutes too early to an appointment, so you decided to take the opportunity to go for a short walk. 
The city provides its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). 
You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block, 
so create a function that will return true if the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.

*/

public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    if (walk.Length == 10) {
      int x = 0;
      int y = 0;
      foreach (string move in walk) {
        if (move == "n") y += 1;
        else if (move == "e") x += 1;
        else if (move == "s") y -= 1;
        else if (move == "w") x -= 1;
      }
      if (x == 0 && y == 0) return true;
    }
    return false;
  }
}
