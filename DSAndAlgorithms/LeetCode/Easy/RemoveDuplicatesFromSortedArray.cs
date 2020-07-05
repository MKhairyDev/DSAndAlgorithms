using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

Example 1:

Given nums = [1,1,2],

Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.

It doesn't matter what you leave beyond the returned length.
Example 2:

Given nums = [0,0,1,1,1,2,2,3,3,4],

Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.

It doesn't matter what values are set beyond the returned length.
     * */
    /// </summary>
    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
        public static int RemoveDuplicates2(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;
            int startIndex = 0;
            int lastIndex = nums.Length-1;
            int deletedItemsCount=0;
            while (startIndex<lastIndex)
            {
                var nextndex = startIndex + 1;
                if (nums[startIndex] == nums[nextndex])
                {

                    while (nextndex < lastIndex)
                    {
                        nums[nextndex] = nums[nextndex + 1];
                        nextndex++;
                    }

                    deletedItemsCount++;
                    lastIndex --;

                }
                else
                {
                    startIndex++;
                }
            }
            return lastIndex;
        }
        public static void Run()
        {
            int[] arr1 = new int[] { 1, 1, 2 };
            int[] arr2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var res2 = RemoveDuplicates(arr2);
            var res = RemoveDuplicates(arr1);
          
        }
    }
}
