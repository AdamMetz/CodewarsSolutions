/*

Create Phone Number (https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp)

Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

*/

public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", 
                        numbers[0], numbers[1], numbers[2], 
                        numbers[3], numbers[4], numbers[5], numbers[6], 
                        numbers[7], numbers[8], numbers[9]);
  }
}
