using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     You are climbing a stair case. It takes n steps to reach to the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

Note: Given n will be a positive integer.

Example 1:

Input: 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:

Input: 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
     */
    /// </summary>
    public class ClimbingStairsProblem
    {
        /// <summary>
        /*
         Complexity Analysis

Time complexity : O(n). Single loop upto nn is required to calculate nth fibonacci number.

Space complexity : O(1). Constant space is used.
         */
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;
            int first = 1;
            int second = 2;
            for (int i = 3; i <= n; i++)
            {
                var third = first + second;
                first = second;
                second = third;
            }
            return second;
        }
        public static void Run()
        {
         var res=   ClimbStairs(2);
            var res2 = ClimbStairs(3);
            var res3 = ClimbStairs(5);
        }
    }
}
