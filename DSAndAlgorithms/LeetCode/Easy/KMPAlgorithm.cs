using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.StringProblems
{
   public class KMPAlgorithm
    {
        /**
* KMP algorithm of pattern matching.
*/
         
        public static int search(String txt, string pat)
        {  // Simulate operation of DFA(deterministic finite-state automaton) on txt.

            int[,] dfa = BuildDFA(pat);
            int i, j, N = txt.Length, M = pat.Length;
            for (i = 0, j = 0; i < N && j < M; i++)
                j = dfa[txt[i], j];
            if (j == M) return i - M;  // found (hit end of pattern)
            else return N;      // not found (hit end of text)
        }

        public static int[,] BuildDFA(string pat)
        {  // Build DFA from pattern.
               int[,] dfa;
            int M = pat.Length;
            int R = 256;
            dfa = new int[R,M];
            int charAsciIndex = pat[0];
            dfa[charAsciIndex, 0] = 1;
            for (int X = 0, j = 1; j < M; j++)
            {  // Compute dfa[][j].
                for (int c = 0; c < R; c++)
                    dfa[c,j] = dfa[c,X];            // Copy mismatch cases.
                dfa[pat[j],j] = j + 1;         // Set match case.
                X = dfa[pat[j],X];           // Update restart state.
            }
            return dfa;
        }




        public static void Run()
        {
            //"mississippi"
            var res6 = search("ABABABABABAC", "ABABAC");
            var res5 = search("hello", "ll");
            var res2 = search("abcxabcdabcdabcy", "abcdabcy");
            var res = search("aaaaa", "bba");
            var res3 = search("mississippi", "issipi");
            var res4 = search("aaa", "aaaa");
        }

    }
}
