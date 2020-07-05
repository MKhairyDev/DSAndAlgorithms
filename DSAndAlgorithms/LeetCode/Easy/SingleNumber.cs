using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Given a non-empty array of integers, every element appears twice except for one. Find that single one.

Note:

Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

Example 1:

Input: [2,2,1]
Output: 1
Example 2:

Input: [4,1,2,1,2]
Output: 4
     */
    /// </summary>
    public class SingleNumberProblem
    {
        /*
 Approach 4: Bit Manipulation
Concept

If we take XOR of zero and some bit, it will return that bit
a ^ 0 =a
If we take XOR of two same bits, it will return 0
a ^ a =0
a^b^a=(a^a)b=0^b=b

Time complexity : O(n)O(n). We only iterate through \text{nums}nums, so the time complexity is the number of elements in \text{nums}nums.

Space complexity : O(1)O(1).
 */
        public static int SingleNumberWithBitmanuiplation(int[] nums)
        {
            int singleNum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                singleNum ^= nums[i];
            }
            return singleNum;
        }
        public static int SingleNumberWithhashTable(int[] nums)
        {
            HashSet<int> lookUp = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!lookUp.Contains(nums[i]))
                    lookUp.Add(nums[i]);
                else
                    lookUp.Remove(nums[i]);
            }
            return lookUp.First();
        }
        /* Math:
       2∗(a+b+c)−(a+a+b+b+c)=c

        Complexity Analysis

Time complexity : O(n + n) = O(n)O(n+n)=O(n). sum will call next to iterate through \text{nums}nums. We can see it as sum(list(i, for i in nums)) which means the time complexity is O(n)O(n) because of the number of elements(nn) in \text{nums}nums.

Space complexity : O(n + n) = O(n)O(n+n)=O(n). set needs space for the elements in nums
        */
        public static int SingleNumberWithMath(int[] nums)
        {
            HashSet<int> lookUp = new HashSet<int>();
            int sumSet = 0;
            int sumNumbers = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!lookUp.Contains(nums[i]))
                {
                    lookUp.Add(nums[i]);
                    sumSet += nums[i];

                }

                sumNumbers += nums[i];


            }
            return (2 * sumSet) - sumNumbers; 
        }

            public static void Run()
        {
          var res2= SingleNumberWithBitmanuiplation(new int[] { 2, 2, 1 });
            var res3 = SingleNumberWithBitmanuiplation(new int[] { 4, 1, 2, 1, 2 });
        }
    }
}
