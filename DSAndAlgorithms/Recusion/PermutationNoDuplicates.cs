using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    class PermutationNoDuplicates
    {
        /*
      Approach 1: Building from permutations of first n-1 characters

         */
        static List<string> printPerms(string s)
        {
            List<string> result = new List<string>();
            var len = s.Length;
            if (len == 0)
            {
                result.Add("");
                return result;
            }

            char currentChar = s[0];
            var remaining = s.Substring(1);
            var permu = printPerms(remaining);
            for (int i = 0; i < permu.Count; i++)
            {
                for (int j = 0; j <= permu[i].Length; j++)
                {
                    var newStr = AddCharAtIndex(permu[i], j, currentChar);
                    result.Add(newStr);
                }

            }

            return result;
        }

        private static string AddCharAtIndex(string s, int index, char currentChar)
        {
            var before = s.Substring(0, index);
            var after = s.Substring(index);
            return before + currentChar + after;
        }

        //***********************************************Second Approach*************************************
        /*
         Approach 2: Building from permutations of all n-1 character substrings.

         */
        static List<string> printPerms2(string s)
        {
            List<string> result = new List<string>();
            if (s.Length==0)
            {
                result.Add("");
                return result;
            }
            for (int i = 0; i < s.Length; i++)
            {
                var before = s.Substring(0, i);
                var after = s.Substring(i + 1);
                var current = s[i];
              var permRes=  printPerms2(before+after);
                for (int j  = 0; j < permRes.Count; j++)
                {
                    result.Add(current + permRes[j]);
                }

            }
            return result;
           
        }
        /*
         Alternatively, instead of passing the permutations back up the stack, we can push the prefix down the stack.
When we get to the bottom (base case), prefix holds a full permutation
         */
        static List<string> printPerms3(string s)
        {
            List<string> result = new List<string>();
            printPerms3Helper("", s, result);
            return result;
        }
        static void printPerms3Helper(string prefix, string remaining, List<string> result)
        {
            if (remaining.Length == 0)
            {
                result.Add(prefix);
            }
            for (int i = 0; i < remaining.Length; i++)
            {
                var before = remaining.Substring(0, i);
                var after = remaining.Substring(i + 1);
                var current = remaining[i];
                printPerms3Helper(prefix + current, before + after, result);

            }
        }
        public static void Run()
        {
            var res = printPerms3("abc");
        }

    }
}
