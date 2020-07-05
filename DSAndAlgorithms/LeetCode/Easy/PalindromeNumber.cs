using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
      Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

Example 1:

Input: 121
Output: true
Example 2:

Input: -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
     */
    /// </summary>
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            int revNum = 0;
           
            while (x>revNum)
            {
                revNum = revNum * 10 + (x % 10);
                x /= 10;
            }
            return x == (revNum / 10)||revNum==x;
        
        }
        public static bool IsPalindrome2(int x)
        {
            if (x < 0)
                return false;
            int startIndex = 0;
            string digitStr = x.ToString();
            int lastIndex = digitStr.Length - 1;
          
            if (digitStr.Length == 1)
                return true;
            while (startIndex < lastIndex)
            {

                if (digitStr[startIndex] != digitStr[lastIndex])
                    return false;
                startIndex++;
                lastIndex--;
            }
            return true;
        }
        static int CountDigit(int n)
        {
            if (n == 0)
                return 1;
            return (int)Math.Floor(Math.Log10(n) + 1);
        }
        public static void Run()
        {
            var res = IsPalindrome(121);
        }
    }

}

