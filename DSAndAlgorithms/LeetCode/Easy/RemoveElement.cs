using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
   public class RemoveElement
    {
        /// <summary>
        /*
         Given an array nums and a value val, remove all instances of that value in-place and return the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

The order of elements can be changed. It doesn't matter what you leave beyond the new length.

Example 1:

Given nums = [3,2,2,3], val = 3,

Your function should return length = 2, with the first two elements of nums being 2.

It doesn't matter what you leave beyond the returned length.
Example 2:

Given nums = [0,1,2,2,3,0,4,2], val = 2,

Your function should return length = 5, with the first five elements of nums containing 0, 1, 3, 0, and 4.

Note that the order of those five elements can be arbitrary.

It doesn't matter what values are set beyond the returned length.
         * */
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int Remove(int[] nums, int val)
        {

            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if(nums[j]!=val)
                {
                    
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }
        public static void Run()
        {
            int[] arr1 = new int[] { 1, 1, 2 };
            int[] arr2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var res2 = Remove(arr2,2);
            var res = Remove(arr1,1);

        }
    }
}
