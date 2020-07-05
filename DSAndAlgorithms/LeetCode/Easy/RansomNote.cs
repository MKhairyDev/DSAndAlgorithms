using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.

Each letter in the magazine string can only be used once in your ransom note.

Note:
You may assume that both strings contain only lowercase letters.

canConstruct("a", "b") -> false
canConstruct("aa", "ab") -> false
canConstruct("aa", "aab") -> true
     */
    /// </summary>
    public class RansomNoteProblem
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char,int> lookUp = new Dictionary<char,int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                if(!lookUp.ContainsKey(magazine[i]))
                {
                    lookUp.Add(magazine[i], 1);
                }
                else
                {
                    lookUp[magazine[i]]++;
                }

            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (!lookUp.ContainsKey(ransomNote[i]))
                    return false;
                if (lookUp[ransomNote[i]]==0)
                    return false;
                lookUp[ransomNote[i]]--;
            }
            return true;
        }
        public static void Run()
        {
            var res = CanConstruct("a","b");
            var res2 = CanConstruct("aa", "ab");
            var res3 = CanConstruct("ba", "aggterb");
            var res4 = CanConstruct("aa", "aab");
        }
    }
}
