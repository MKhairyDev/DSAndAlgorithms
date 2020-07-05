using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

Examples:

s = "leetcode"
return 0.

s = "loveleetcode",
return 2.
Note: You may assume the string contain only lowercase letters.
     */
    /// </summary>
    public class FirstUniqueCharacterInString
    {
        /// <summary>
        /*
         Complexity Analysis

Time complexity : \mathcal{O}(N) since we go through the string of length N two times.
Space complexity : \mathcal{O}(N) since we have to keep a hash map with N elements.
         */
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

            public static int FirstUniqChar(string s)
        {
            Dictionary<char,int> lookUp = new Dictionary<char,int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!lookUp.ContainsKey(s[i]))
                {
                    //if character exists only once we add it's index otherwise add -1
                    lookUp.Add(s[i], i);
                }
                else
                {
                    lookUp[s[i]] = -1; ;
                }

            }
            foreach (var item in lookUp)
            {
               if(item.Value!=-1)
                {
                    return item.Value;
                }
            }
            return -1;
        }
        public static int FirstUniqChar2(string s)
        {
            Dictionary<char, int> lookUp = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!lookUp.ContainsKey(s[i]))
                {
                    lookUp.Add(s[i], 1);
                }
                else
                {
                    lookUp[s[i]]++; 
                }

            }
            for (int i = 0; i < s.Length; i++)
            {

                if (lookUp[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void Run()
        {
            var res=FirstUniqChar("leetcode");
            var res2 = FirstUniqChar("loveleetcode");
            var res3 = FirstUniqChar("loveleetcode");
        }
    }
}
