using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
  public class ImplementIndexOfString
    {
        /// <summary>
        /*
         Implement strStr().

Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Example 1:

Input: haystack = "hello", needle = "ll"
Output: 2
Example 2:

Input: haystack = "aaaaa", needle = "bba"
Output: -1
         */
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;
            if (needle.Length > haystack.Length)
                return -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (i + needle.Length > haystack.Length)
                        return -1;
                    var newSubString = haystack.Substring(i, needle.Length);
                    if (newSubString == needle)
                        return i;
                }

            }
            return -1;
        }
        /**
* Slow method of pattern matching
*/
        public bool hasSubstring(char[] text, char[] pattern)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < text.Length && j < pattern.Length)
            {
                if (text[i] == pattern[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    j = 0;
                    k++;
                    i = k;
                }
            }
            if (j == pattern.Length)
            {
                return true;
            }
            return false;
        }
        public static void Run()
        {
            //"mississippi"
            
            var res2 = StrStr("hello", "ll");
            var res = StrStr("aaaaa", "bba");
            var res3 = StrStr("mississippi", "issipi");
            var res4 = StrStr("aaa", "aaaa");
        }
    }
}
