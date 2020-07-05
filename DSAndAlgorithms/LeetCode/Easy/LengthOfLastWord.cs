using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word (last word means the last appearing word if we loop from left to right) in the string.

If the last word does not exist, return 0.

Note: A word is defined as a maximal substring consisting of non-space characters only.

Example:

Input: "Hello World"
Output: 5
     */
    /// </summary>
    class LengthOfLastWordProblem
    {
        public static int LengthOfLastWord(string s)
        {
            int len = 0;

            // String a is 'final'-- can 
            // not be modified So, create 
            // a copy and trim the 
            // spaces from both sides 
            string x = s.Trim();

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == ' ')
                {
                    len = 0;
                }
                else
                {
                    len++;
                }
            }

            return len;

        }
        public static int LengthOfLastWord2(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return 0;
            }
            var spiltRes = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (spiltRes.Length ==0)
                return 0;
            return spiltRes[spiltRes.Length - 1].Length;
        }
        public static void Run()
        {
         var res=   LengthOfLastWord("Hello World");
            var res2 = LengthOfLastWord("Hello");
            var res3 = LengthOfLastWord("Hello    ");
            var res4 = LengthOfLastWord(" ");
            var res5 = LengthOfLastWord("a");
            var res6 = LengthOfLastWord("    day");
        }
    }
}
