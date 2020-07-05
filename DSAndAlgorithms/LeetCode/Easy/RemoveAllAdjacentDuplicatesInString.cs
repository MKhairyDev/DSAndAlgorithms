using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Given a string S of lowercase letters, a duplicate removal consists of choosing two adjacent and equal letters, and removing them.

We repeatedly make duplicate removals on S until we no longer can.

Return the final string after all such duplicate removals have been made.  It is guaranteed the answer is unique.

 

Example 1:

Input: "abbaca"
Output: "ca"
Explanation: 
For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".
 

Note:

1 <= S.length <= 20000
S consists only of English lowercase letters.
     */
    /// </summary>
    public class RemoveAllAdjacentDuplicatesInString
    {
        public static string RemoveDuplicates(string S)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(S[0]);
            for (int i = 1; i < S.Length; i++)
            {
                if(stack.Count>0&& S[i]==stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(S[i]);
                }
            }
            string newStr = "";
            while(stack.Count>0)
            {
                newStr = stack.Pop()+ newStr ;
            }
            return newStr;
        }

        public static void Run()
        {
          var res= RemoveDuplicates("abbaca");
        }
    }
}
