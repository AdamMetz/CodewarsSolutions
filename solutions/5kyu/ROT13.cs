/*

ROT13 (https://www.codewars.com/kata/52223df9e8f98c7aa7000062/train/csharp)

How can you tell an extrovert from an introvert at NSA?
Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.

I found this joke on USENET, but the punchline is scrambled. Maybe you can decipher it?
According to Wikipedia, ROT13 is frequently used to obfuscate jokes on USENET.

For this task you're only supposed to substitute characters. Not spaces, punctuation, numbers, etc.

Test examples:

"EBG13 rknzcyr." -> "ROT13 example."

"This is my first ROT13 excercise!" -> "Guvf vf zl svefg EBG13 rkprepvfr!"

*/

using System;

public class Kata
{
  public static string Rot13(string input)
  {
    string rot13Result = "";
    
    foreach (char c in input) {
      if (char.IsLetter(c)) {
        char baseChar = char.IsUpper(c) ? 'A' : 'a';
        rot13Result += (char)((c - baseChar + 13) % 26 + baseChar);
      } else {
        rot13Result += c;
      }
    }
    
    return rot13Result;
  }
}
