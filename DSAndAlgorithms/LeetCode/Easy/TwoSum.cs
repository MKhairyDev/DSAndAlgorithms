using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /// Given an array of integers, return indices of the two numbers such that they add up to a 
    /// specific target.
    ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// </summary>
   public class TwoSumProblem
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];

            for (int i = 0; i < nums.Length-1; i++)
            {

                for (int j = i+1; j < nums.Length ; j++)
                {

                    var sumRes=nums[i] + nums[j];
                    
                    if (sumRes == target)
                    {
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }
                    
                }
            }
            return res;
        }
        public static int[] TwoSum2(int[] nums, int target)
        {
            int[] res = new int[2];
            Dictionary<int, int> lookUp = new Dictionary<int, int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                lookUp.Add(i, nums[i-1]);
            }
           //Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {

                    var sumRes=target- nums[i];
                  var key=  lookUp.FirstOrDefault(x => x.Value == sumRes&&x.Key>i+1).Key;
                if (key > 0)
                    {
                        res[0] = i;
                        res[1] = key-1;
                        return res;
                    }
                
            }
            return res;
        }
        public static void Run()
        {
           var res= TwoSum2(new int []{ 0, 4, 3, 0},0);
        }
    }
}
