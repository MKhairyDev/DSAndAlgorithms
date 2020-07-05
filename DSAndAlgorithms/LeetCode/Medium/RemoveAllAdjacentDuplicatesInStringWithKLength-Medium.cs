using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
Given a string s, a k duplicate removal consists of choosing k adjacent and equal letters from s and removing them causing the left and the right side of the deleted substring to concatenate together.

We repeatedly make k duplicate removals on s until we no longer can.

Return the final string after all such duplicate removals have been made.

It is guaranteed that the answer is unique.

 

Example 1:

Input: s = "abcd", k = 2
Output: "abcd"
Explanation: There's nothing to delete.
Example 2:

Input: s = "deeedbbcccbdaa", k = 3
Output: "aa"
Explanation: 
First delete "eee" and "ccc", get "ddbbbdaa"
Then delete "bbb", get "dddaa"
Finally delete "ddd", get "aa"
Example 3:

Input: s = "pbbcggttciiippooaais", k = 2
Output: "ps"
 

Constraints:

1 <= s.length <= 10^5
2 <= k <= 10^4
s only contains lower case English letters.
     */
    /// </summary>
    public class RemoveAllAdjacentDuplicatesInStringWithKLength
    {
        class stackManager
        {
           public char Val;
           public int count;
        }
        public static string RemoveDuplicates(string s, int k)
        {
            Stack<stackManager> stack = new Stack<stackManager>();
            stack.Push(new stackManager() { Val = s[0], count = 1 });
            for (int i = 1; i < s.Length; i++)
            {
                if (stack.Count > 0 && s[i] == stack.Peek().Val)
                {
                    if (stack.Peek().count + 1 == k)
                    {
                        stack.Pop();

                    }
                    else
                    {
                        var count = stack.Pop().count + 1;
                        stack.Push(new stackManager() { Val = s[i], count = count });
                    }
                }
                else
                {
                    stack.Push(new stackManager() { Val = s[i], count = 1 });
                }
            }
            string newStr = "";
            while (stack.Count > 0)
            {
                var stackManager = stack.Pop();
                for (int i = 0; i < stackManager.count; i++)
                {
                    newStr = stackManager.Val + newStr;
                }

            }
            return newStr;
        }

        public static void Run()
        {
            var res = RemoveDuplicates("abcd", 2);
            var res2 = RemoveDuplicates("deeedbbcccbdaa", 3);
            var res3 = RemoveDuplicates("pbbcggttciiippooaais", 2);
        }
    }
}
