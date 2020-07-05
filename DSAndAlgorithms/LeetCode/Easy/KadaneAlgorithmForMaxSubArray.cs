using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
   public class KadaneAlgorithmForMaxSubArray
    {
        /// <summary>
        /*
         Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

Example:

Input: [-2,1,-3,4,-1,2,1,-5,4],
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
Follow up:

If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
         */
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubArray(int[] nums)
        {
            int currentMax = nums[0];
            int globalMax = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentMax = Math.Max(nums[i], nums[i] + currentMax);
                globalMax = Math.Max(currentMax, globalMax);
            }
            return globalMax;
        }
        public static int MaxSubArrayWithIndicesTracking(int[] nums)
        {
            int currentMax = nums[0];
            int globalMax = nums[0];
            int startIndex = 0;
            int lastIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i] + currentMax)
                {
                    currentMax = nums[i] + currentMax;
                }
                else
                {
                    currentMax = nums[i];
                    startIndex = i;
                }
                if (currentMax > globalMax)
                {
                    globalMax = currentMax;
                    lastIndex = i;
                }
            }
            return globalMax;
        }
        public static void Run()
        {
        var res=    MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        }
    }
}
