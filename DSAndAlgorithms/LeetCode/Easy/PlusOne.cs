using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /*

Given a non-empty array of digits representing a non-negative integer, plus one to the integer.

The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.

You may assume the integer does not contain any leading zero, except the number 0 itself.

Example 1:

Input: [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Example 2:

Input: [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
*/
   public class PlusOneProblem
    {
        static int[] PlusOne(int[] digits)
        {
            int carrier = 1;
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                int sum = 0;
                sum = digits[i] + carrier;
                var digit = sum % 10;
                carrier = sum / 10;
                digits[i]= digit;

            }

            if (carrier > 0)
            {
                Array.Resize(ref digits, n + 1);
                digits[0] = carrier;
            }
            return digits;
        }
        static int[] PlusOne2(int[] digits)
            {
            int carrier = 1;
            List<int> newList = new List<int>();
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                int sum = 0;
                sum = digits[i] + carrier;
                var digit = sum % 10;
                carrier = sum / 10;
                newList.Insert(0, digit);

            }
      
            if (carrier > 0)
                newList.Insert(0, carrier);
            return newList.ToArray();
        }
            public static void Run()
            {
            var res3 = PlusOne(new int[] { 9, 9, 9 });
            var res = PlusOne(new int[] { 1, 2, 3 });
            var res2 = PlusOne(new int[] { 4, 3, 2, 1 });
        }
        }
    


}
