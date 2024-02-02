/*

RGB To Hex Conversion (https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp)

The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. 
Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.

Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.

*/

using System;

public class Kata
{
  private const int MIN_RGB_COLOUR_VALUE = 0;
  private const int MAX_RGB_COLOUR_VALUE = 255;
  
  public static string Rgb(int r, int g, int b) 
  {
    int[] RGBValues = new int[3]{r, g, b};
    string hexValue = "";
    foreach (int colourValue in RGBValues) {
      int clampedValue = Math.Clamp(colourValue, MIN_RGB_COLOUR_VALUE, MAX_RGB_COLOUR_VALUE);
      if (clampedValue <= 15) hexValue += "0"; // Pad a 0 for single hex digit numbers
      hexValue += clampedValue.ToString("x").ToUpper();
    }
    return hexValue;
  }
}
