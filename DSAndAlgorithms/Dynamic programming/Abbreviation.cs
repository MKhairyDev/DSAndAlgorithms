using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Dynamic_programming
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/abbr/problem?h_r=next-challenge&h_v=zen
    /// </summary>
    class AbbreviationProblem
    {
     
        static string Abbreviation(string a, string b)
        {
          List<List<bool>> dp = new List<List<bool>>();


            for (int i = 0; i <= a.Length; i++)
            {
                dp.Add(new List<bool>());
                for (int j = 0; j <= b.Length; j++)
                {
                    dp[i].Add(false);
                }
            }
            dp[0][0] = true;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j <= b.Length; j++) if (dp[i][j])
                    {
                        if (j < b.Length && (char.ToUpper(a[i]) == b[j])) dp[i + 1][j + 1] = true;
                        if (char.IsLower (a[i])) dp[i + 1][j] = true;
                    }
            }

            return dp[a.Length][b.Length] == true ? "YES" : "NO";

        }
        static bool isPossible = false;
        static bool[][] lookup;
        static string Abbreviation2(string a, string b)
        {
            HashSet<string> lookUp = new HashSet<string>();
            isPossible = false;
            AbbreviationHelper2(a, b, lookUp);
            return isPossible ? "YES":"NO";

        }
        static void AbbreviationHelper2(string a, string b, HashSet<string> lookup)
        {

            if (isPossible || a.Length < b.Length)
                return ;


            if (string.IsNullOrEmpty(b))
            {

                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsUpper(a[i]))
                    {
                        isPossible = false;
                        return;
                    }
                }
                isPossible = true;
                return;
            }


            var conc = a + "#" + b;
            if (!lookup.Add(conc))
            {
                return;
            }
            var aChar = a[0];
            var bChar = b[0];
            if (char.IsLower(aChar))
            {
                 AbbreviationHelper2(a.Remove(0, 1), b, lookup);
            }
            if (char.ToUpper(aChar) != bChar)
            {
                 return;
            }

             AbbreviationHelper2(a.Remove(0, 1), b.Remove(0, 1), lookup);
        }


        public static void Run()
        {
            var res6 = Abbreviation("abaaA", "AB");
            var res = Abbreviation("abcdefghijklmnopqrstuvwxyzababababAbAbaBabAbababababAbababaBabaBabAbaBababababababababaBababaBababababaBabaBabababABabababAbabababaBAbababababababababababAbababaBabababAbabababababababaBaBabAbabaBababababababababaBAbabaBAbabAbababababaBababAbababababababaBabababababaBaBaBababababAbabaBababaBaBabababababababababababababababababababAbababababababababAbababaBababababababababAbabaBabababaBAbabababababababababababababababaBababAbabababaBAbababababaBabababababababaBaBabababababababAbababababababababAbabababaBabAbabaBabAbAbabAbaBabababababaBaBababABabababababAbaBababababababaBabababababababababababAbababababababababababababababababaBabababababababababababababababAbabaBababababababababababaBAbabababAbababababababababaBabababaBaBabababababababababaBababAbaBababAbababababaBAbababaBababababababAbABabababAbababaBababababababaBaBababababAbAbabababababababababaBababababababababababababababababaBabababAbabAbababababABabababAbabababababababababaBabABCDEFGHIJKLMNOPQRSTUVWXYZ", "ABCDEFGHIJKLMNOPQRSTUVWXYZAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBAABBABCDEFGHIJKLMNOPQRSTUVWXYZ");
            var res5 = Abbreviation("aBbd", "BBD");
            var res2 = Abbreviation("daBcd", "ABC");
            var res3 = Abbreviation("daBcdD", "ABC");
            var res4 = Abbreviation("daBBcd", "ABC");
        }

    }
}
