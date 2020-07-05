using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

You may assume that the array is non-empty and the majority element always exist in the array.

Example 1:

Input: [3,2,3]
Output: 3
Example 2:

Input: [2,2,1,1,1,2,2]
Output: 2
     */
    /// </summary>
   public class MajorityElementProblem
    {
        /// <summary>
        /*
         Approach: Boyer-Moore Voting Algorithm
Intuition

If we had some way of counting instances of the majority element as +1+1 and instances of any other element as -1−1, summing them would make it obvious that
the majority element is indeed the majority element.

Algorithm

Essentially, what Boyer-Moore does is look for a suffix sufsuf of nums where suf[0]suf[0] is the majority element in that suffix. 
To do this, we maintain a count, which is incremented whenever we see an instance of our current candidate for majority element and decremented whenever we see anything else. Whenever count equals 0, we effectively forget about everything in nums up to the current index and consider the current number as the candidate for majority element. It is not immediately obvious why we can get away with forgetting prefixes of nums - consider the following examples (pipes are inserted to separate runs of nonzero count).

[7, 7, 5, 7, 5, 1 | 5, 7 | 5, 5, 7, 7 | 7, 7, 7, 7]

Here, the 7 at index 0 is selected to be the first candidate for majority element. count will eventually reach 0 after index 5 is processed,
so the 5 at index 6 will be the next candidate. In this case, 7 is the true majority element, so by disregarding this prefix, we are ignoring
an equal number of majority and minority elements - therefore, 7 will still be the majority element in the suffix formed by throwing away the first prefix.

[7, 7, 5, 7, 5, 1 | 5, 7 | 5, 5, 7, 7 | 5, 5, 5, 5]

Now, the majority element is 5 (we changed the last run of the array from 7s to 5s), but our first candidate is still 7. In this case,
our candidate is not the true majority element, but we still cannot discard more majority elements than minority elements 
(this would imply that count could reach -1 before we reassign candidate, which is obviously false).

Therefore, given that it is impossible (in both cases) to discard more majority elements than minority elements, we are safe in discarding 
the prefix and attempting to recursively solve the majority element problem for the suffix. Eventually, a suffix will be found for which 
count does not hit 0, and the majority element of that suffix will necessarily be the same as the majority element of the overall array.

             Complexity Analysis

Time complexity : O(n)

Boyer-Moore performs constant work exactly nn times, so the algorithm runs in linear time.

Space complexity : O(1)

Boyer-Moore allocates only constant additional memory.
         */
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MajorityElement(int[] nums)
        {
            int majIndex = 0;
            int count = 1;
            for (int i = 1 ; i < nums.Length; i++)
            {
                if(nums[majIndex] ==nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                    if(count==0)
                    {
                        majIndex = i;
                        count = 1;
                    }
                }

            }
            return nums[majIndex];
        }
        /// <summary>
        /*
         Complexity Analysis

Time complexity : O(n)

We iterate over nums once and make a constant time HashMap insertion on each iteration. Therefore, the algorithm runs in O(n)O(n) time.

Space complexity : O(n)

majority element itself), leaving us with (at most)  n - (n/2) distinct elements.

​
         */
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MajorityElement2(int[] nums)
        {
            Dictionary<int, int> lookup = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(!lookup.ContainsKey(nums[i]))
                {
                    lookup.Add(nums[i], 1);
                }
                else
                {
                    lookup[nums[i]] ++;
                }
            }
            int majorityElement = 0;
            int maxCount = 0;
            foreach (var item in lookup)
            {
                if(item.Value> maxCount)
                {
                    maxCount = item.Value;
                    majorityElement = item.Key;
                }
            }

            return majorityElement;
        }
        public static void Run()
        {
            var res = MajorityElement(new int[] { 3, 2, 3 });
            var res2 = MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2});
        }
    }
}
