using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
Note:

All given inputs are in lowercase letters a-z.
      */
    /// </summary>
    public class LongestCommonPrefix
    {
        /*
         Complexity Analysis

In the worst case we have nn equal strings with length mm
Time complexity : O(S log n), where S is the sum of all characters in all strings.

The algorithm makes \log nlogn iterations, for each of them there are S = m \cdot nS=m⋅n comparisons, which gives in total O(S log n) time complexity.

Space complexity : O(1)O(1). We only used constant extra space.
         */
        public static string Check(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            int minLen = int.MaxValue;
            foreach (String str in strs)
                minLen = Math.Min(minLen, str.Length);
            int low = 1;
            int high = minLen;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (isCommonPrefix(strs, middle))
                    low = middle + 1;
                else
                    high = middle - 1;
            }
            return strs[0].Substring(0, (low + high) / 2);
        }

        private static bool isCommonPrefix(String[] strs, int len)
        {
            String str1 = strs[0].Substring(0, len);
            for (int i = 1; i < strs.Length; i++)
                if (!strs[i].StartsWith(str1))
                    return false;
            return true;
        }
    
        public static string Check2(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                        return strs[0].Substring(0, i);
                }
            }
            return strs[0];
        }
        public static string Check3(string[] strs)
        {
            /*
             Time complexity : O(S)O(S) , where S is the sum of all characters in all strings.
             In the worst case all nn strings are the same. The algorithm compares the string S1S1 with the other strings [S_2 \ldots S_n][S 2 …S n​	 ]
             There are SS character comparisons, where SS is the sum of all characters in the input array.
             Space complexity : O(1)O(1). We only used constant extra space.
             * */
            if (strs.Length == 0) return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";
                }
            return prefix;
        }
        public static string Check4(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));
            var firstStr = strs[0];
            List<string> strRresList = new List<string>() { ""};
            var strRresListIndex = 0;
            bool newPrefixFlag=false;
            for (int i = 0; i < firstStr.Length; i++)
            {
                if (CheckIfCharExist(strs, firstStr[i], i))
                {
   
                    if (newPrefixFlag)
                    {
                        newPrefixFlag = false;
                        strRresListIndex++;
                        strRresList.Add("");
                    }

                        strRresList[strRresListIndex] += firstStr[i];

                }
                else
                {
                    newPrefixFlag = true;
                
                }
            }
            strRresList.Sort();
            return strRresList[0];
        }
        private static bool CheckIfCharExist(string[] strs,char prefix,int prefixIndex)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j][prefixIndex] != prefix)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Run()
        {
            var res = Check(new string[] { "flower", "flow", "flight" });
            var res2 = Check(new string[] { "dog", "racecar", "car" });
        }
    }
}
