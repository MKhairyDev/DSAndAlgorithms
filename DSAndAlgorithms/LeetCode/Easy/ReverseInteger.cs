using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /// Given a 32-bit signed integer, reverse digits of an integer.
     /*
      * Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
    */
    /// </summary>
    public class ReverseInteger
    {
        //Time Complexity: O(\log(x)). There are roughly \log_{10}(x)digits in xx.
        public static int Reverse(int x)
        {
            int rev_num = 0;
            int prev_rev_num = 0;
            bool isNegativeNum = false;
            if(x<0)
            {
                isNegativeNum = true;
                x = -x;
            }
            while (x > 0)
            {
              int currentDigit=  x % 10;
                rev_num = rev_num * 10 + currentDigit;
                if((rev_num-currentDigit)/10!= prev_rev_num)
                {
                    return 0;
                }
                x = x / 10;

                prev_rev_num = rev_num;
            }
            return isNegativeNum == true ? -rev_num : rev_num;

        }

        public static void Run()
        {
            var res = Reverse(-123);
        }
    }
}
