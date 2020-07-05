using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    public class ValidParentheses
    {
        /*
         Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
         An input string is valid if:
         Open brackets must be closed by the same type of brackets.
         Open brackets must be closed in the correct order.
         Note that an empty string is also considered valid.
         Input: "()"
         Output: true
         
            Example 2:
         Input: "()[]{}"
         Output: true
         Example 3:
         Input: "(]"
         Output: false
         
            Example 4:
            Input: "([)]"
            Output: false
            Example 5:
            Input: "{[]}"
            Output: true
         */
        public static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            Dictionary<char, char> lookUp = new Dictionary<char, char>();
            lookUp.Add('(', ')');
            lookUp.Add('{', '}');
            lookUp.Add('[', ']');
            Stack<char> stackOpenParentheses = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (lookUp.ContainsKey(s[i]))
                {
                    stackOpenParentheses.Push(s[i]);
                }
                else
                {

                    if (stackOpenParentheses.Count == 0)
                        return false;
                        var latestParen = stackOpenParentheses.Pop();
                        var closeParenExpected = lookUp[latestParen];
                        if (closeParenExpected != s[i])
                        {
                            return false;
                        }
                    

                }

            }
            if(stackOpenParentheses.Count>0)
            {
                return false;
            }
            return true;

        }
        public static void Run()
        {
            var res = IsValid( "()[]{}" );
            var res2 = IsValid("{[]}");
            var res3 = IsValid("(]");
            var res4 = IsValid("([)]");
            var res5 = IsValid("[");
            var res6 = IsValid("]");
        }
    }
}
