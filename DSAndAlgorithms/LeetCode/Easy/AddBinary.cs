using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
      Given two binary strings, return their sum (also a binary string).

The input strings are both non-empty and contains only characters 1 or 0.

Example 1:

Input: a = "11", b = "1"
Output: "100"
Example 2:

Input: a = "1010", b = "1011"
Output: "10101"
 

Constraints:

Each string consists only of '0' or '1' characters.
1 <= a.length, b.length <= 10^4
Each string is either "0" or doesn't contain any leading zero.
     */
    /// </summary>
    public class AddBinaryProblem
    {
        public static string AddBinary(string a, string b)
        {
            int i=a.Length-1;
            int j = b.Length-1;
            string result = ""; // Initialize result 
            int sum = 0; // Initialize digit sum 
            while (i >= 0 || j >= 0 || sum == 1)
            {

                // Compute sum of last digits and carry 
                sum += ((i >= 0) ?int.Parse( a[i].ToString()) :0 );
                sum += ((j >= 0) ? int.Parse(b[j].ToString()) : 0 );

                // If current digit sum is 1 or 3,  
                // add 1 to result 
                result = (sum % 2 + 0 ).ToString()+ result;

                // Compute carry 
                sum /= 2;

                // Move to next digits 
                i--;
                j--;
            }
            if(sum>0)
            {
                result = sum + result;
            }
            return result;

        }

        public static void Run()
        {
            var res4 = AddBinary("1111", "1111");
            var res3 = AddBinary("1", "111");
            var res = AddBinary("11", "1");
            var res2 = AddBinary("1010", "1011");
        }
    }
}
