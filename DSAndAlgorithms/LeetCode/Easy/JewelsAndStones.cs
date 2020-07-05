using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, so "a" is considered a different type of stone from "A".

Example 1:

Input: J = "aA", S = "aAAbbbb"
Output: 3
Example 2:

Input: J = "z", S = "ZZ"
Output: 0
Note:

S and J will consist of letters and have length at most 50.
The characters in J are distinct.
     */
    /// </summary>
    public class JewelsAndStones
    {
        public static int NumJewelsInStones(string J, string S)
        {
            var bag = J.ToHashSet();
            return S.Count(bag.Contains);
        }
        public static int NumJewelsInStones2(string J, string S)
        {
            if (string.IsNullOrEmpty(J) || string.IsNullOrEmpty(S))
                return 0;

            HashSet<char> lookUp = new HashSet<char>();
            int sum = 0;
            for (int i = 0; i < J.Length; i++)
            {
                lookUp.Add(J[i]);
            }
            for (int i = 0; i < S.Length; i++)
            {
                if(lookUp.Contains(S[i]))
                {
                    sum++;
                }
  
            }
   
            return sum;
        }
        public static void Run()
        {
          var res=  NumJewelsInStones("aA", "aAAbbbb");
            var res2 = NumJewelsInStones("z", "ZZ");
            var res3 = NumJewelsInStones("a", "bbbcccfa");
            var res4 = NumJewelsInStones("k", "bbbcccfa");
            var res5 = NumJewelsInStones("", "bbbcccfa");
            var res6 = NumJewelsInStones("k", "0");
        }
    }
}
