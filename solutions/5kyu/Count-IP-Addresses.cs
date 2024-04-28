/*

Count IP Addresses (https://www.codewars.com/kata/526989a41034285187000de4/train/csharp)

Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).

All inputs will be valid IPv4 addresses in the form of strings. The last address will always be greater than the first one.

Examples
* With input "10.0.0.0", "10.0.0.50"  => return   50 
* With input "10.0.0.0", "10.0.1.0"   => return  256 
* With input "20.0.0.10", "20.0.1.0"  => return  246

*/

using System;
public class CountIPAddresses
{
   public static long IpsBetween(string start, string end)
   {
    string[] startIPparts = start.Split(".");
    string[] endIPparts = end.Split(".");

    long ipsCount = 0;

    for (int i = 0; i < 4 ; i++) {
      long multiplier = (long)Math.Pow(256, 3-i);
      ipsCount += (Int32.Parse(endIPparts[i]) - Int32.Parse(startIPparts[i])) * multiplier;
    }

    return ipsCount;
   }
}
