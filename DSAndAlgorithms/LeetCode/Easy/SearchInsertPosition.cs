using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
   public class SearchInsertPosition
    {
        /// <summary>
        /*
         Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.

Example 1:

Input: [1,3,5,6], 5
Output: 2
Example 2:

Input: [1,3,5,6], 2
Output: 1
Example 3:

Input: [1,3,5,6], 7
Output: 4
Example 4:

Input: [1,3,5,6], 0
Output: 0
         */
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns> 
        public static int SearchInsert(int[] nums, int target)
        {
     
                if (nums.Length < 1)
                {
                    return 0;
                }

                int low = 0;
                int high = nums.Length - 1;
                int mid;
                int pos=0;
                while (low <= high)
                {
                    mid = low + (high - low) / 2;

                    if (nums[mid] == target)
                    {
                        return mid;
                    }
                    else if (nums[mid] > target)
                    {
                        high = mid - 1;
                        pos = mid;
                    }
                    else
                    {
                        low = mid + 1;
                        pos = mid + 1;
                    }
                }

                return pos;
            
        }
    
        public static int SearchInsert2(int[] nums, int target)
        {

            return BinarySearch(nums, target, 0, nums.Length-1);
        }
        private static int BinarySearch(int[] nums, int target,int min,int max)
        {

            if(min>=max)
            {
                if (nums[min] < target)
                    return min + 1;
                else
                {
                    return min;
                }
            }
         
                
            int mid =min+( max-min) / 2;
            if (nums[mid] == target)
                return mid;
            if (nums[mid] > target)
             return   BinarySearch(nums, target, 0, mid - 1);
            else 
              return  BinarySearch(nums,target, mid + 1, max);
       
        }
        public static void Run()
        {
            var re5 = SearchInsert(new int[] { 1, 3}, 2);
            var res = SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
            var res2 = SearchInsert(new int[] { 1, 3, 5, 6 }, 7);
            var re3 = SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            var re4 = SearchInsert(new int[] { 1, 3, 5, 6 }, 0);
        }
    }
}
