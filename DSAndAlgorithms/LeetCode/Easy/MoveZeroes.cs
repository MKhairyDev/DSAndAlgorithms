namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]
Note:

You must do this in-place without making a copy of the array.
Minimize the total number of operations.
     */
    /// </summary>
    public static class MoveZeroesProblem
    {
        /// <summary>
        /*
         Complexity Analysis

Space Complexity : O(1). Only constant space is used.

Time Complexity: O(n). However, the total number of operations are optimal. The total operations (array writes) that code does is Number of non-0 elements.This gives us a much better best-case (when most of the elements are 0) complexity than last solution. However,
the worst-case (when all elements are non-0) complexity for both the algorithms is same.
         */
        /// </summary>
        /// <param name="nums"></param>
        public static void MoveZeroes(int[] nums)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != 0)
                {

                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;

                }

            }
        }
        public static void MoveZeroes2(int[] nums)
        {
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if(nums[i]==0)
                {
                    if (nums[j] != 0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        i++;
                    }
                }
                else
                {
                    i++;
                }
       
            }
        }
        public static void Run()
        {
            var arr = new int[] { 0, 1, 0, 3, 12 };
             var arr2 = new int[] {1,0,1  };
            var arr3 = new int[] {0,0,0 };
            var arr4 = new int[] { 0, 0, 0,1 };
            MoveZeroes(arr);
            MoveZeroes(arr2);
            MoveZeroes(arr3);
            MoveZeroes(arr4);

        }
    }
}
