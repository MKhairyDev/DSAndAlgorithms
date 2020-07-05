using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    class PermutationWithDuplicates
    {
        /*
         Permutations with Duplicates: Write a method to compute all permutations of a string whose
         characters are not necessarily unique. The list of permutations should not have duplicates.
         */
        static List<string> printPerms(string s)
        {
            List<string> result = new List<string>();
            Dictionary<char, int> map = buildFreqTable(s);
            printPerms(map, "", s.Length, result);
            return result;
            }
       static Dictionary<char, int> buildFreqTable(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in s.ToCharArray())
            {
                if (!map.ContainsKey(c))
                {
                    map.Add(c, 0);
                }
                map[c] = map[c] + 1;
            }
            return map;
        }

        static void printPerms(Dictionary<char, int> map, string prefix, int remaining,
          List<string> result)
        {
            /* Base case. Permutation has been completed. */
            if (remaining == 0)
            {
                result.Add(prefix);
                return;
            }

            /* Try remaining letters for next char, and generate remaining permutations. */

            foreach (char c in map.Keys.ToList())
            {
                int count = map[c];
                if (count > 0)
                {
                    map[c] = count - 1;
                    printPerms(map, prefix + c, remaining - 1, result);
                    map[c] = count;
                }
            }
        }
        public static void Run()
        {
         var res=   printPerms("aab");
        }

    }
}
